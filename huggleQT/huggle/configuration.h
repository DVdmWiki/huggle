//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.


#ifndef CONFIGURATION_H
#define CONFIGURATION_H

#include <QList>
#include <QString>
#include "user.h"
#include "wikisite.h"

class Configuration
{
public:
    //! Verbosity for debugging to terminal etc, can be switched with parameter --verbosity
    static unsigned int Verbosity;
    //! currently selected project
    static WikiSite Project;
    static QString UserName;
    static bool UsingSSL;
    static QString GetURLProtocolPrefix();
    static QList<WikiSite> ProjectList;
    static QString WmfOAuthConsumerKey;
    Configuration();
};

#endif // CONFIGURATION_H