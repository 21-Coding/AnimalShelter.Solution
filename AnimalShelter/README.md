


# _Animal Shelter_

#### By _**Dom Youmans**_

   ![enter image description here](https://media.giphy.com/media/SB5fjrUhAeLte/giphy.gif)



## Description

This is a ASP.NET core API application used to track animals in a shelter.

## Specifications and User Stories: 

* A user is able to GET a list of all animals. 
* A user is able to POST a new animal to the database.
* A user is able to GET details on specific animals.
* A user is able to PUT and DELETE Animals from database.

## API Endpoints
	

    GET /api/Animals
    POST /api/Animals
    GET /api/Animals/{AnimalId}
    PUT /api/Animals/{AnimalId}
    DELETE /api/Animals/{AnimalId}
 
 

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/drakewilcox/LocalBusinessTrackerAPI.Solution``
* ``cd LocalBusinessTrackerAPI.Solution``

_Confirm that you have navigated to the HairSalon.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Change into the working directory of the project to begin recreating the ``drake_wilcox`` database:_
* ``cd LocalBusinessTrackerAPI``

_Run the migration command to populate your MySQL server with the Database and Tables and Seed Data associated with this project:_
* ``dotnet restore``
* ``dotnet build``
* ``dotnet ef database update``

_From the production folder ``LocalBusinessTrackerAPI`` Run this application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_`
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_To test this API after running the application, Use Postman or view the [Swagger UI](http://localhost:5000/swagger) to view and test routes._

_To view/edit the source code of this application, open the contents of the ``LocalBusinessTrackerAPI.Solution`` directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## 	Further Exploration

![SwaggerIO Logo](data:image/png;base64,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)

**Running Swagger Documentation**

 - after you have successfully used the command `dotnet run` in your projects production folder:
	 - go to the following link: [http://localhost:5000/index.html](http://localhost:5000/index.html)

## Technologies Used
* _Git_
* _HTML_
* _CSS_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC (version 2.2)_
* _Razor_
* _dotnet script_
* _MySQL 8.0 CE_
* _MySQL Workbench 8.0 CE_
* _Entity Framework Core 2.2_
* _ASP.NET Core MVC Versioning 3.1.6

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dom Youmans_**