//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#ifndef HUGGLEQUEUEITEMLABEL_H
#define HUGGLEQUEUEITEMLABEL_H

#include <QMouseEvent>
#include <QFrame>
#include "core.h"

namespace Ui {
class HuggleQueueItemLabel;
}

class WikiEdit;
class HuggleQueue;
class HuggleQueueItemLabel : public QFrame
{
    Q_OBJECT
    
public:
    explicit HuggleQueueItemLabel(QWidget *parent = 0);
    ~HuggleQueueItemLabel();
    HuggleQueue *ParentQueue;
    void SetName(QString name);
    QString GetName();
    void Process();
    WikiEdit *page;
    static int Count;
    
private slots:
    void on_label_2_linkActivated(const QString &link);

protected:
    void mousePressEvent(QMouseEvent *event);

private:
    Ui::HuggleQueueItemLabel *ui;
};

#endif // HUGGLEQUEUEITEMLABEL_H
