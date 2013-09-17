//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#include "hugglequeueitemlabel.h"
#include "ui_hugglequeueitemlabel.h"

int HuggleQueueItemLabel::Count = 0;

HuggleQueueItemLabel::HuggleQueueItemLabel(QWidget *parent) : QFrame(parent), ui(new Ui::HuggleQueueItemLabel)
{
    ParentQueue = (HuggleQueue*)parent;
    ui->setupUi(this);
}

HuggleQueueItemLabel::~HuggleQueueItemLabel()
{
    delete ui;
}

void HuggleQueueItemLabel::SetName(QString name)
{
    ui->label_2->setText(name);
    if (this->page != NULL)
    {
        // change the icon according to edit type
        if (this->page->OwnEdit)
        {
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-me.png"));
            return;
        }

        switch (this->page->CurrentUserWarningLevel)
        {
        case WarningLevelNone:
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-none.png"));
            return;
        case WarningLevel1:
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-warn-1.png"));
            return;
        case WarningLevel2:
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-warn-2.png"));
            return;
        case WarningLevel3:
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-warn-3.png"));
            return;
        case WarningLevel4:
            ui->label->setPixmap(QPixmap(":/huggle/pictures/Resources/blob-warn-4.png"));
            return;
        }
    }
}

QString HuggleQueueItemLabel::GetName()
{
    return ui->label_2->text();
}

void HuggleQueueItemLabel::Process()
{
    HuggleQueueItemLabel::Count--;
    if (this->ParentQueue->Items.contains(this))
    {
        this->ParentQueue->Items.removeOne(this);
    }
    Core::ProcessEdit(this->page);
    this->hide();
    this->close();
}

void HuggleQueueItemLabel::on_label_2_linkActivated(const QString &link)
{
    QApplication::exit();
}

void HuggleQueueItemLabel::mousePressEvent(QMouseEvent *event)
{
    if (event->button() == Qt::LeftButton)
    {
        this->Process();
    }
}
