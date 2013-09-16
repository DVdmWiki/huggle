//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#ifndef HUGGLETOOL_H
#define HUGGLETOOL_H

#include <QDockWidget>

namespace Ui {
class HuggleTool;
}

class HuggleTool : public QDockWidget
{
    Q_OBJECT
    
public:
    explicit HuggleTool(QWidget *parent = 0);
    ~HuggleTool();
    void SetTitle(QString title);
    void SetInfo(QString info);
    void SetUser(QString user);
    
private:
    Ui::HuggleTool *ui;
};

#endif // HUGGLETOOL_H
