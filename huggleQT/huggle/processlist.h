//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#ifndef PROCESSLIST_H
#define PROCESSLIST_H

#include <QList>
#include <QTableWidgetItem>
#include <QDateTime>
#include <QHeaderView>
#include <QDockWidget>
#include "query.h"
#include "exception.h"

namespace Ui {
class ProcessList;
}

class ProcessListRemovedItem
{
private:
    QDateTime time;
    int id;
public:
    ProcessListRemovedItem(int ID);
    int GetID();
    bool Expired();
};

class ProcessList : public QDockWidget
{
    Q_OBJECT
    
public:
    explicit ProcessList(QWidget *parent = 0);
    void InsertQuery(Query* q);
    void Clear();
    bool ContainsQuery(Query *q);
    void RemoveQuery(Query *q);
    void UpdateQuery(Query *q);
    bool IsExpired(Query *q);
    void RemoveExpired();
    int GetItem(Query *q);
    int GetItem(int Id);
    ~ProcessList();
    
private:
    QList<ProcessListRemovedItem*> *Removed;
    Ui::ProcessList *ui;
};

#endif // PROCESSLIST_H
