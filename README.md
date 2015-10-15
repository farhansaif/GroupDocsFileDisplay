#### DEPLOYMENT GUIDE

This application is Built on .Net Framework 4.0 & MVC 4. Download the source code in a folder on physical drive of your PC. 


##### HOW TO DEPLOY CODE IN IIS

- Create a Virtual Directory in IIS. (Provide the physical path to deployment folder). 
- Select correct Application Pool i.e. Mode and .Net Framework version and give required permissions). 


##### HOW TO CONFIGURE CODE IN VISUAL STUDIO

- You can open this application in Visual Studio 2010, Visual Studio 1012, Visual Studio 2013 and Visual Studio 2015. Then Open the Visual Studio. Go To File -> New Project.
- Select Empty ASP.NET MVC 4 Web Application and .Net Framework 4.0.
- Once the new project with the solution is opened in the Visual Studio, delete and existing project and leave the Solution File.
- Now add the Existing Project  to the Solution i.e. select Project file from the download Project folder.
- DLLs folder in the solution contains Groupdocs.Viewer.dll. This needs to be referenced in the Project.
- Use Nuget to add missing references.
- Remove the Nuget Package from the project i.e. Remove the packages folder and the packages.config file.

- Open the Package Manager Console 

- First Execute the following command

    uninstall-Package Microsoft.AspNet.SignalR -Version 1.1.3
    
- Then Execute the following command

    Install-Package Microsoft.AspNet.SignalR -Version 1.1.3
    
- Include the packages folder and packages.config file in the project

For more information please read [Technical Article](https://github.com/farhansaif/GroupDocsFileDisplay/wiki/Technical-Article) on Groupdocs Viewer to display documents.
