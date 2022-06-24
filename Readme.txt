1. Create project

Visual Studio 2022
ASP.NET Core Web Core (Model-View-Controller)
Project Name: LeaveManagement.Web
Solution Name: LeaveManagementNet6 
Project and solution NOT in the same directory
Framework: .NET 6.0
Authentication: Individual Account

2. Connect database and extend the identity user table

Connect database (ConnectionStrings in appsetting.json)

Create Employee (User) class (model) in Data folder, inherited from IdentityUser. 
-> By inheriting from IdentityUser, the properties (columns) of Employee class add new columns to the existing User table (AspNetUsers).

Specify TUser in IdentityDbContext in ApplicationDbContext.cs - IdentityDbContext<Employee>

Update default identity (IdentityUser -> Employee). Program.cs

Update database with adding new columns to the user table
View > Other Windows > Package Manager Console
> add-migration ExtendedUserTable
> update-database

