# RentACar-BackEnd

Car rental project written in accordance with SOLID principles. Used technologies and techniques in this project:
DOTNET framework, Resful API, SQL Server, Entity Framework, Dependency Injection and AOP by Autofac, FluentValidation, JWT.
Project Installation

    Clone the repository
    Open the project in Visual Studio
    Install database

Database Installation

    Find your SQL Server name in the "SQL Server Object Explorer" then change server name in "DataAccess/Concrete/EntityFramework/RentACarContext.cs
    Open cmd or any command shell in DataAccess file
    Run dotnet tool install --global dotnet-ef command to install .Net Entity Framework CLI
    Run dotnet ef database update to create the database

How to use

    Set WebAPI project as Startup Project and start the project
    Navigate https://localhost:7001 to view.
Frontend of this project: https://github.com/OmerFarukTastan/RentACar-FrontEnd
