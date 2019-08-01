# Synchrolean-server
Synchrolean is a task management application with a focus on team collaboration and transparency. Synchrolean promotes individual bottom up organization. Synchrolean Server acts as the web api for both the front end web application and the front end mobile application.

## Getting Started
These instructions will help you get a working copy of Synchrolean Server running on your machine for development and testing purposes.

### Prerequisites MacOS

What you need to run Synchrolean Server on MacOS

- Download and install Visual Studio or Visual Studio Code for MacOS from Microsoft
- Download and install the ASP.NET Core runtime and sdk for MacOS from Microsoft

### Installing on MacOS

- Download the repository and Unzip it
- Open terminal and navigate to the SynchroLean folder in the location where you unzipped the repository
- For Visual Studio Code development run the command ``dotnet restore`` and then run ``dotnet ef database update``. Finally, run the command ``dotnet run``.

### Prerequisites Windows

What you need to run Synchrolean Server on Windows

- Download and install Visual Studio or Visual Studio Code for Windows from Microsoft
- Download and install the ASP.NET Core runtime and sdk for Windows from Microsoft

### Installing on Windows

- Download the repository and Unzip it
- Open a terminal and navigate to the SynchroLean folder in the location where you unzipped the repository
- For Visual Studio Code development run the command ``dotnet restore`` and then run ``dotnet ef database update``. Finally, run the command ``dotnet run``.
- For Visual Studio development use the nuget package manager to restore packages and then run ``dotnet run`` from the command line (or run the project using the green play button)

## Deployment

These instructions are specific to deploying on Google Cloud Platform using a Database hosted on AWS. Deploying on other services will likely have similar steps you can find online.

- Install [Google Cloud SDK](https://cloud.google.com/sdk/)
- Create a [Google Cloud Platform](https://cloud.google.com/) (GCP) account.
- [Create a new project](https://cloud.google.com/resource-manager/docs/creating-managing-projects)
- Open Visual Studio (not Visual Studio Code).
- Go to Tools > Extensions & Updates
- Click Online and Search "Google" and Download Google Cloud Tools for Visual Studio
- Go to Tools > Google Cloud Tools -> Show Google Cloud Explorer (restart Visual Studio if this doesn't show up).
- Add your GCP account.
- Select the project you created earlier
- Open terminal and navigate to the SynchroLean folder in the location where you unzipped the repository
- Run the command ``dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL``
- Run the command ``dotnet restore``
- Add the appropraite connection string to appsettings.json. [Example PostgreSQL Connection Strings](https://www.connectionstrings.com/postgresql/)
- Change dbcontext setup in startup.cs to use npgsql and the new connection string. Save and close startup.cs before next step.
- Delete all existing migrations from the Migrations folder.
- Run ``dotnet ef migrations add ReleaseCandidate<Number>`` (replacing <Number> with One, Two, Three, etc.)
- Run ``dotnet ef database drop``. Confirm the database drop if asked.
- Run ``dotnet ef database update``
- Right click project -> Publish to Google Cloud.. -> App Engine Flex -> Select the GCP project -> install services -> publish.
- If the publish is successful, the server is now up and running!

## Built With
- [Visual Studio Code](https://code.visualstudio.com) - Microsoft's source code editor with developer tooling
- [Visual Studio](https://visualstudio.microsoft.com) - Microsoft's IDE for development on the .NET framework
- [ASP.NET Core 2.1](https://docs.microsoft.com/en-us/aspnet/core/getting-started) - Microsoft's unified Web Development model

## Backend Authors
- **Alex Goddard** - [AlexGoddard](https://github.com/AlexGoddard)
- **Barend Venter**
- **Cole Phares** - [zedzorander](https://github.com/zedzorander)
- **Edward Hazelwood**
- **Alex Ferguson** - [Decklan](https://github.com/Decklan)

## License
GNU Affero General Public License v3.0

## Acknowledgements
The team members of Synchrolean would like to acknowledge Matt Horvat for sponsoring this project as our senior capstone.
