# DotNetAPICourse

Hello and welcome to this C# Dotnet Core course!

Inside of this repository you will find all of the code from various sections of the course.

If you are opting to skip the SQL section of the course you can also use the SQL scripts inside of this repository to prepare your database for the interactions from the API.

Congratulations on taking this step in your learning journey, and I am excited to see you inside!
https://github.com/DomTripodi93/DotNetAPICourse

dotnet new console -n hello-worlds
dotnet run
dotnet watch run
dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org
dotnet nuget list source
dotnet restores
dotnet run parametro
dotnet add package Dapper --versionm
dotnet add package microsoft.data.sqlclient
dotnet add package microsoft.entityframeworks
dotnet add package microsoft.Extensions.Configurations
dotnet add package microsoft.Extensions.Configurations.Json
dotnet.restore
dotnet add package Newtonsoft.Json
dotnet add package  autoMappers

//// api 1
dotnet f webapi --name dotNetAPI
dotnet add package  Dapper
dotnet add package  autoMappers
dotnet add package microsoft.data.sqlclient
dotnet add package microsoft.entityframeworksCore
dotnet add package microsoft.entityframeworksCore.Relational
dotnet add package microsoft.entityframeworksCore.SqlServer
dotnet add package microsoft.AspNetCore.Aunthentication.JwtBearer


/////////
use master
eliminar la base de datoss
CREATE DATABASE DotNetCourseDatabase
GO

USE DotNetCourseDatabase
GO

CREATE SCHEMA TutorialAppSchema
GO

CREATE TABLE TutorialAppSchema.Computer(
	ComputerId INT IDENTITY(1,1) PRIMARY KEY,
	Motherboard NVARCHAR(50),
	CPUCores INT,
	HasWifi BIT,
	HasLTE BIT,
	ReleaseDate DATE,
	Price DECIMAL(18,4),
	VideoCard NVARCHAR(50)
);


deploy in azure
login in azure cli
dotnet build --configuration Release
az webpaap up --sku F1 --name "name" --os-type linux

