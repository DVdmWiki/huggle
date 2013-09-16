//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#include "login.h"
#include "ui_login.h"

QString Login::Test = "<login result=\"NeedToken\" token=\"";

Login::Login(QWidget *parent) :   QDialog(parent),   ui(new Ui::Login)
{
    ui->setupUi(this);
    this->_Status = Nothing;
    this->timer = new QTimer(this);
    connect(this->timer, SIGNAL(timeout()), this, SLOT(on_Time()));
    this->setWindowTitle("Huggle 3 QT");
    this->Reset();
    ui->checkBox->setChecked(Configuration::UsingSSL);
    // set the language to dummy english
    ui->Language->addItem("English");
    ui->Language->setCurrentIndex(0);
    int current = 0;
    while (current < Configuration::ProjectList.size())
    {
        ui->Project->addItem(Configuration::ProjectList.at(current).Name);
        current++;
    }
    ui->Project->setCurrentIndex(0);
    wq = NULL;
}

Login::~Login()
{
    delete wq;
    delete LoginQuery;
    delete ui;
    delete timer;
}

void Login::Progress(int progress)
{
    ui->progressBar->setValue(progress);
}

void Login::Reset()
{
    ui->label_6->setText("Please enter your wikipedia username and pick a project. The authentication will be processed using OAuth.");
}

void Login::CancelLogin()
{
    this->timer->stop();
    ui->progressBar->setValue(0);
    this->Enable();
    this->_Status = Nothing;
    ui->ButtonOK->setText("Login");
}

void Login::Enable()
{
    ui->lineEdit->setEnabled(true);
    ui->Language->setEnabled(true);
    ui->Project->setEnabled(true);
    ui->checkBox->setEnabled(true);
    ui->lineEdit_2->setEnabled(true);
    ui->ButtonExit->setEnabled(true);
    ui->lineEdit_3->setEnabled(true);
}

void Login::Disable()
{
    ui->lineEdit->setDisabled(true);
    ui->Language->setDisabled(true);
    ui->Project->setDisabled(true);
    ui->checkBox->setDisabled(true);
    ui->ButtonExit->setDisabled(true);
    ui->lineEdit_3->setDisabled(true);
    ui->lineEdit_2->setDisabled(true);
}

void Login::PressOK()
{
    if (ui->lineEdit_2->text() == "Developer Mode")
    {
        DeveloperMode();
        return;
    }
    if (ui->tab->isVisible())
    {
        QMessageBox mb;
        mb.setWindowTitle("Function not supported");
        mb.setText("This function is not available for wmf wikis in this moment");
        mb.exec();
        //mb.setStyle(QStyle::SP_MessageBoxCritical);
        return;
    }
    Configuration::Project = Configuration::ProjectList.at(ui->Project->currentIndex());
    Configuration::UserName = ui->lineEdit_2->text();
    Configuration::Password = ui->lineEdit_3->text();
    this->_Status = LoggingIn;
    Configuration::UsingSSL = ui->checkBox->isChecked();
    this->Disable();
    ui->ButtonOK->setText("Cancel");
    // First of all, we need to login to the site
    this->timer->start(200);
    //this->Thread->start();
}

void Login::PerformLogin()
{
    ui->label_6->setText("Logging in");
    this->Progress(10);
    // we create an api request to login
    this->LoginQuery = new ApiQuery();
    this->LoginQuery->SetAction(ActionLogin);
    this->LoginQuery->Parameters = "lgname=" + QUrl::toPercentEncoding(Configuration::UserName);
    this->LoginQuery->UsingPOST = true;
    this->LoginQuery->Process();
    this->_Status = WaitingForLoginQuery;
}

void Login::FinishLogin()
{
    if (!this->LoginQuery->Processed())
    {
        return;
    }
    if (this->LoginQuery->Result->Failed)
    {
        ui->label_6->setText("Login failed: " + this->LoginQuery->Result->ErrorMessage);
        this->Progress(0);
        this->_Status = LoginFailed;
        delete this->LoginQuery;
        this->LoginQuery = NULL;
        return;
    }
    this->Progress(20);
    Core::DebugLog(this->LoginQuery->Result->Data, 6);
    this->Token = this->LoginQuery->Result->Data;
    this->_Status = WaitingForToken;
    delete this->LoginQuery;
    this->Token = GetToken();
    this->LoginQuery = new ApiQuery();
    this->LoginQuery->SetAction(ActionLogin);
    this->LoginQuery->Parameters = "lgname=" + QUrl::toPercentEncoding(Configuration::UserName)
            + "&lgpassword=" + QUrl::toPercentEncoding(Configuration::Password) + "&lgtoken=" + Token ;
    this->LoginQuery->UsingPOST = true;
    this->LoginQuery->Process();
}

void Login::FinishToken()
{
    if (!this->LoginQuery->Processed())
    {
        return;
    }
    if (this->LoginQuery->Result->Failed)
    {
        ui->label_6->setText("Login failed: " + this->LoginQuery->Result->ErrorMessage);
        this->Progress(0);
        this->_Status = LoginFailed;
        delete this->LoginQuery;
        this->LoginQuery = NULL;
        return;
    }
    this->Progress(60);

    // this is last step but in fact we should load the config now
    Core::DebugLog(this->LoginQuery->Result->Data, 6);

    // Assume login was successful
    if (this->ProcessOutput())
    {
        // Get a whitelist
        this->_Status = RetrievingWhitelist;
    }
    // that's all
    delete this->LoginQuery;
    this->LoginQuery = NULL;
}

void Login::RetrieveWhitelist()
{
    if (wq != NULL)
    {
        if (wq->Processed())
        {
            Configuration::WhiteList = wq->Result->Data.split("|");
            delete wq;
            wq = NULL;
            this->_Status = LoginDone;
            Finish();
            return;
        }
        return;
    }
    this->Progress(80);
    ui->label_6->setText("Retrieving whitelist");
    wq = new WLQuery();
    wq->Process();
    return;
}

void Login::DeveloperMode()
{
    Configuration::Restricted = true;
    Core::Main = new MainWindow();
    Core::Main->show();
    this->hide();
}

void Login::DisplayError(QString message)
{
    this->_Status = LoginFailed;
    Core::DebugLog(this->LoginQuery->Result->Data);
    ui->label_6->setText(message);
    this->CancelLogin();
}

void Login::Finish()
{
    this->timer->stop();
    Core::Main = new MainWindow();
    this->hide();
    Core::Main->show();
}

bool Login::ProcessOutput()
{
    // Check what the result was
    QString Result = this->LoginQuery->Result->Data;
    if (!Result.contains(("<login result")))
    {
        DisplayError("ERROR: The api.php responded with invalid text (webserver is down?), please check debug log for precise information");
        return false;
    }

    Result = Result.mid(Result.indexOf("result=\"") + 8);
    if (!Result.contains("\""))
    {
        DisplayError("ERROR: The api.php responded with invalid text (webserver is broken), please check debug log for precise information");
        return false;
    }

    Result = Result.mid(0, Result.indexOf("\""));

    if (Result == "Success")
    {
        return true;
    }

    if (Result == "EmptyPass")
    {
        DisplayError("The password you entered was empty");
        return false;
    }

    if (Result == "WrongPass")
    {
        DisplayError("Your password is not correct");
        return false;
    }

    if (Result == "NoName")
    {
        DisplayError("You provided no correct user name for login");
        return false;
    }

    DisplayError("ERROR: The api.php responded with unknown result: " + Result);
    return false;
}

QString Login::GetToken()
{
    QString token = this->Token;
    if (!token.contains(Login::Test))
    {
        // this is invalid token?
        Core::Log("WARNING: the result of api request doesn't contain valid token");
        Core::DebugLog("The token didn't contain the correct string, token was " + token);
        return "<invalid token>";
    }
    token = token.mid(token.indexOf(Login::Test) + Login::Test.length());
    if (!token.contains("\""))
    {
        // this is invalid token?
        Core::Log("WARNING: the result of api request doesn't contain valid token");
        Core::DebugLog("The token didn't contain the closing mark, token was " + token);
        return "<invalid token>";
    }
    token = token.mid(0, token.indexOf("\""));
    return token;
}

void Login::on_ButtonOK_clicked()
{
    if (this->_Status == Nothing)
    {
        this->PressOK();
        return;
    }

    if (this->_Status == LoggingIn)
    {
        this->CancelLogin();
        return;
    }
}

void Login::on_ButtonExit_clicked()
{
    Core::Shutdown();
}

void Login::on_Login_destroyed()
{
    QApplication::quit();
}

void Login::on_Time()
{
    switch (this->_Status)
    {
    case LoggingIn:
        PerformLogin();
        break;
    case WaitingForLoginQuery:
        FinishLogin();
        break;
    case RetrievingWhitelist:
        RetrieveWhitelist();
        break;
    case WaitingForToken:
        FinishToken();
        break;
    case LoggedIn:
    case Nothing:
    case Cancelling:
    case LoginFailed:
    case LoginDone:
        break;
    }
    if (this->_Status == LoginFailed)
    {
        this->Enable();
        timer->stop();
        ui->ButtonOK->setText("Login");
        this->_Status = Nothing;
    }
}

