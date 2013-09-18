//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#include "huggleweb.h"
#include "ui_huggleweb.h"

HuggleWeb::HuggleWeb(QWidget *parent) :
    QFrame(parent),
    ui(new Ui::HuggleWeb)
{
    ui->setupUi(this);
    CurrentPage = "No page is displayed now";
}

HuggleWeb::~HuggleWeb()
{
    delete ui;
}

QString HuggleWeb::CurrentPageName()
{
    return CurrentPage;
}

void HuggleWeb::DisplayPreFormattedPage(WikiPage *page)
{
    ui->webView->history()->clear();
    ui->webView->load(Core::GetProjectScriptURL() + "index.php?title=" + page->PageName + "&action=render");
    CurrentPage = page->PageName;
}

void HuggleWeb::DisplayPreFormattedPage(QString url)
{
    ui->webView->history()->clear();
    ui->webView->load(url + "&action=render");
    CurrentPage = ui->webView->title();
}

void HuggleWeb::DisplayPage(QString url)
{
    ui->webView->load(url);
}

void HuggleWeb::RenderHtml(QString html)
{
    ui->webView->setContent(html.toUtf8());
}

QString HuggleWeb::Encode(const QString &string)
{
    QString encoded;
    for(int i=0;i<string.size();++i)
    {
        QChar ch = string.at(i);
        if(ch.unicode() > 255)
        {
            encoded += QString("&#%1;").arg((int)ch.unicode());
        }
        else
        {
            encoded += ch;
        }
    }
    return encoded;
}

void HuggleWeb::DisplayDiff(WikiEdit *edit)
{
    ui->webView->history()->clear();
    if (edit == NULL)
    {
        throw new Exception("The page of edit was NULL in HuggleWeb::DisplayDiff(*edit)");
    }
    if (edit->Page == NULL)
    {
        throw new Exception("The page of edit was NULL in HuggleWeb::DisplayDiff(*edit)");
    }
    if (edit->DiffText == "")
    {
        Core::Log("Warning, unable to retrieve diff for edit " + edit->Page->PageName + " fallback to web rendering");
        ui->webView->load(Core::GetProjectScriptURL() + "index.php?title=" + edit->Page->PageName + "&diff="
                      + QString::number(edit->Diff) + "&action=render");
        return;
    }

    QString Summary;

    if (edit->Summary == "")
    {
        Summary = "<font color=red>No summary was provided</font>";
    } else
    {
        Summary = Encode(edit->Summary);
    }

    ui->webView->setHtml(Core::HtmlHeader + "<tr></td colspan=2><b>Summary:</b> "
                         + Summary + "</td></tr>" + edit->DiffText
                         + Core::HtmlFooter);
}
