//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#include "hugglequeue.h"
#include "ui_hugglequeue.h"

HuggleQueue::HuggleQueue(QWidget *parent) :
    QDockWidget(parent),
    ui(new Ui::HuggleQueue)
{
    ui->setupUi(this);
    CurrentFilter = new HuggleQueueFilter(this);
    this->layout = new QVBoxLayout(ui->scrollArea);
    this->layout->setMargin(0);
    this->layout->setSpacing(0);
    this->xx = new QWidget();
    this->frame = new QFrame();
    ui->scrollArea->setWidget(this->xx);
    xx->setLayout(this->layout);
    this->layout->addWidget(this->frame);
    ui->comboBox->addItem(this->CurrentFilter->QueueName);
    ui->comboBox->setCurrentIndex(0);
}

HuggleQueue::~HuggleQueue()
{
    delete layout;
    delete CurrentFilter;
    delete ui;
}

void HuggleQueue::AddItem(WikiEdit *page)
{
    // so we need to insert the item somehow
    HuggleQueueItemLabel *label = new HuggleQueueItemLabel(this);
    label->page = page;
    label->SetName(page->Page->PageName);
    this->layout->addWidget(label);
    this->Items.append(label);
    HuggleQueueItemLabel::Count++;
}

void HuggleQueue::Next()
{
    if (HuggleQueueItemLabel::Count < 1)
    {
        return;
    }
    QLayoutItem *i = this->layout->itemAt(1);
    HuggleQueueItemLabel *label = (HuggleQueueItemLabel*)i->widget();
    label->Process();
    this->layout->removeItem(i);
}
