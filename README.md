# WEB315 
 In the first, I used command "dotnet new webapp -o RazorPagesComputer
code -r RazorPagesComputer"  in VScode for creating new web app then i used another command for lisence that is "dotnet dev-certs https --trust"
after this, I added models folder and in that I computer.cs, then run the following command "dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.* " for The command-line interface (CLI) tools for EF Core.
for the scaffolding tool produces pages for Create, Read, Update, and Delete (CRUD) operations for the movie model the command i used is
dotnet-aspnet-codegenerator razorpage -m Computer -dc RazorPagesComputerContext -udl -outDir Pages/Computers --referenceScriptLibraries -sqlite
and after this all i did some changes in startup.cs
then I used this command "dotnet ef migrations add InitialCreate  dotnet ef database update" for migration and database update.
I did minnor and major changes in files and also added filter option to my assignment. 
Side by side I use to test my code by using dotnet watch run command.
