//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

#ifndef HUGGLEFEEDPROVIDERWIKI_H
#define HUGGLEFEEDPROVIDERWIKI_H

#include <QList>
#include <QStringList>
#include <QString>
#include <QtXml/QtXml>
#include <QDateTime>
#include "core.h"
#include "hugglefeed.h"
#include "apiquery.h"
//#include "hugglequeuefilter.h"
#include "configuration.h"
#include "wikiedit.h"

class ApiQuery;

class HuggleFeedProviderWiki : public HuggleFeed
{
public:
    HuggleFeedProviderWiki();
    ~HuggleFeedProviderWiki();
    bool Start();
    bool IsWorking();
    void Stop();
    bool Restart() { this->Stop(); return this->Start(); }
    bool ContainsEdit();
    void Refresh();
    WikiEdit *RetrieveEdit();
private:
    QDateTime LatestTime;
    void Process(QString data);
    bool Refreshing;
    QList<WikiEdit> *Buffer;
    ApiQuery *q;
    void InsertEdit(WikiEdit edit);
};

#endif // HUGGLEFEEDPROVIDERWIKI_H
