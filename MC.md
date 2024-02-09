# C# .NET Core 7 with MS SQL Complete Beginner to Master 2023

<!-- TOC -->

- [C# .NET Core 7 with MS SQL Complete Beginner to Master 2023](#c-net-core-7-with-ms-sql-complete-beginner-to-master-2023)
    - [Introduction [1]](#introduction-1)
    - [Install List [2]](#install-list-2)
    - [NET 7 [3]](#net-7-3)
    - [Install [4]](#install-4)
    - [Mac/Linux Install MS SQL Server - Notes [5]](#maclinux-install-ms-sql-server---notes-5)
    - [Mac/Linux Install MS SQL Server [6]](#maclinux-install-ms-sql-server-6)
    - [Hotkeys and Macros [7]](#hotkeys-and-macros-7)
    - [Basics Theory Pt 1 [8]](#basics-theory-pt-1-8)
    - [Console App Theory [9]](#console-app-theory-9)
    - [Creating a Console App [10]](#creating-a-console-app-10)
    - [Basic Theory Pt 2 [11]](#basic-theory-pt-2-11)
    - [Console.WriteLine [12]](#consolewriteline-12)
    - [Console App Template [13]](#console-app-template-13)
    - [Variables Notes [14]](#variables-notes-14)
    - [Variables [15]](#variables-15)
    - [Data Structures [16]](#data-structures-16)
    - [Operators and Conditionals [17]](#operators-and-conditionals-17)
    - [Basic Theory Pt 3 [18]](#basic-theory-pt-3-18)
    - [Conditional Statements [19]](#conditional-statements-19)
    - [Loops [20]](#loops-20)
    - [Methods [21]](#methods-21)
    - [Scope [22]](#scope-22)
    - [Intermediate Theory [23]](#intermediate-theory-23)
    - [Models [24]](#models-24)
    - [Property Defaults [25]](#property-defaults-25)
    - [Namespaces [26]](#namespaces-26)
    - [Computer SQL Script [27]](#computer-sql-script-27)
    - [MacOS and Linux Users [28]](#macos-and-linux-users-28)
    - [Windows Connection Troubleshooting [29]](#windows-connection-troubleshooting-29)
    - [Database Connections [30]](#database-connections-30)
    - [Error converting data type varchar to numeric [31]](#error-converting-data-type-varchar-to-numeric-31)
    - [Dapper Pt 1 [32]](#dapper-pt-1-32)
    - [Dapper Pt 2 [33]](#dapper-pt-2-33)
    - [Entity Framework [34]](#entity-framework-34)
    - [Config [35]](#config-35)
    - [Intermediate Theory Pt 2 [36]](#intermediate-theory-pt-2-36)
    - [File Read and Write [37]](#file-read-and-write-37)
    - [JSON [38]](#json-38)
    - [Model Mapping [39]](#model-mapping-39)
    - [Skipping Crash Course [40]](#skipping-crash-course-40)
    - [MacOS and Linux Users [41]](#macos-and-linux-users-41)
    - [SQL Seed [42]](#sql-seed-42)
    - [SQL - Basics Pt1 [43]](#sql---basics-pt1-43)
    - [SQL - Basics Pt2 [44]](#sql---basics-pt2-44)
    - [SQL - Intermediate [45]](#sql---intermediate-45)
    - [API Basics Theory [46]](#api-basics-theory-46)
    - [NET 7 default run [47]](#net-7-default-run-47)
    - [Getting Started [48]](#getting-started-48)
    - [Startup.cs [49]](#startupcs-49)
    - [First Custom Controller [50]](#first-custom-controller-50)
    - [NET 7 launchSettings.json [51]](#net-7-launchsettingsjson-51)
    - [API Setup [52]](#api-setup-52)
    - [MacOS and Linux Users [53]](#macos-and-linux-users-53)
    - [Database Connection [54]](#database-connection-54)
    - [Http Launch [55]](#http-launch-55)
    - [User Models [56]](#user-models-56)
    - [Users Controller [57]](#users-controller-57)
    - [Put & Post [58]](#put--post-58)
    - [DTOs [59]](#dtos-59)
    - [Namespaces [60]](#namespaces-60)
    - [User Delete [61]](#user-delete-61)
    - [EF Setup [62]](#ef-setup-62)
    - [EF User Controller [63]](#ef-user-controller-63)
    - [AutoMapper [64]](#automapper-64)
    - [Beginner Assignment [65]](#beginner-assignment-65)
    - [Beginner Assignment Solution Dapper [66]](#beginner-assignment-solution-dapper-66)
    - [Beginner Assignment Solution Entity Framework [67]](#beginner-assignment-solution-entity-framework-67)
    - [API Intermediate Theory [68]](#api-intermediate-theory-68)
    - [UserRepository [69]](#userrepository-69)
    - [IUserRepository [70]](#iuserrepository-70)
    - [Repository Peripherals [71]](#repository-peripherals-71)
    - [Auth Table SQL [72]](#auth-table-sql-72)
    - [Auth Settings and Models [73]](#auth-settings-and-models-73)
    - [Password Managment [74]](#password-managment-74)
    - [Login [75]](#login-75)
    - [Registration With Details [76]](#registration-with-details-76)
    - [NET 7 Note - IConfiguration.GetSection [77]](#net-7-note---iconfigurationgetsection-77)
    - [JWT Token Creation [78]](#jwt-token-creation-78)
    - [JWT Token Validation [79]](#jwt-token-validation-79)
    - [Helpers [80]](#helpers-80)
    - [Posts Model [81]](#posts-model-81)
    - [Posts Controller [82]](#posts-controller-82)
    - [Posts Search [83]](#posts-search-83)
    - [Stored Procedure Creation [84]](#stored-procedure-creation-84)
    - [Parameters [85]](#parameters-85)
    - [Nullable Parameters [86]](#nullable-parameters-86)
    - [Join and Outer Apply [87]](#join-and-outer-apply-87)
    - [Temp Table [88]](#temp-table-88)
    - [User Upsert [89]](#user-upsert-89)
    - [User Upsert Peripherals [90]](#user-upsert-peripherals-90)
    - [User Delete [91]](#user-delete-91)
    - [Posts Get [92]](#posts-get-92)
    - [Post Upsert [93]](#post-upsert-93)
    - [Post Delete [94]](#post-delete-94)
    - [Auth [95]](#auth-95)
    - [API Advanced Theory [96]](#api-advanced-theory-96)
    - [Stored Procedures Script [97]](#stored-procedures-script-97)
    - [UserComplete Setup and Get [98]](#usercomplete-setup-and-get-98)
    - [UserComplete Upsert [99]](#usercomplete-upsert-99)
    - [User Delete [100]](#user-delete-100)
    - [Posts Get [101]](#posts-get-101)
    - [My Posts [102]](#my-posts-102)
    - [Post Upsert [103]](#post-upsert-103)
    - [Post Delete [104]](#post-delete-104)
    - [Auth Register [105]](#auth-register-105)
    - [Reset Password [106]](#reset-password-106)
    - [Login [107]](#login-107)
    - [Cleanup [108]](#cleanup-108)
    - [User Controller DynamicParameters [109]](#user-controller-dynamicparameters-109)
    - [Advanced Assignment [110]](#advanced-assignment-110)
    - [Advanced Assignment Solution [111]](#advanced-assignment-solution-111)
    - [Reusable SQL [112]](#reusable-sql-112)
    - [Azure App Service [113]](#azure-app-service-113)
    - [Azure Database Creation [114]](#azure-database-creation-114)
    - [Azure SQL Seed [115]](#azure-sql-seed-115)
    - [Azure Database Connection [116]](#azure-database-connection-116)
    - [Azure Deploy with Database Connection [117]](#azure-deploy-with-database-connection-117)
    - [Delete Azure Resources [118]](#delete-azure-resources-118)
    - [Congratulations! [119]](#congratulations-119)

<!-- /TOC -->

## Introduction [1]
<https://github.com/DomTripodi93/DotNetAPICourse>
## Install List [2]
## .NET 7 [3]
## Install [4]
## Mac/Linux Install MS SQL Server - Notes [5]
## Mac/Linux Install MS SQL Server [6]
## Hotkeys and Macros [7]
## Basics Theory Pt 1 [8]
## Console App Theory [9]
## Creating a Console App [10]
## Basic Theory Pt 2 [11]
## Console.WriteLine [12]
## Console App Template [13]
## Variables Notes [14]
## Variables [15]
## Data Structures [16]
## Operators and Conditionals [17]
## Basic Theory Pt 3 [18]
## Conditional Statements [19]
## Loops [20]
## Methods [21]
## Scope [22]
## Intermediate Theory [23]

## Models [24]

## Property Defaults [25]

- third-party libraries could look for props, not for fields
- public string Motherboard
  - "Easy workaround" with nullable ? ,
  - **NO!** - set a default value, or init it in ctor!
  
```cs
    public class Computer
    {
        public string Motherboard { get; set; } = string.Empty;
        public int CPUCores { get; set; }
        ...
    }
```

- code .
- dotnet run

## Namespaces [26]
## Computer SQL Script [27]
## MacOS and Linux Users [28]
## Windows Connection Troubleshooting [29]
## Database Connections [30]

```sql
-- best to use?
IF DB_ID('dms') IS NOT NULL
   --code mine :)
   print 'db exists'

-- From a Microsoft's script:
DECLARE @dbname nvarchar(128)
SET @dbname = N'Senna'

IF (EXISTS (SELECT name 
FROM master.dbo.databases 
WHERE ('[' + name + ']' = @dbname 
OR name = @dbname)))

```

```sql
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
```

View Schema:

```
SSMS -> Object Explorer -> Database Name -> Database Diagram-> RC (Right Click) -> New Database diagram -> Add table
```

```

mkdir Code
dotnet new console -n HelloWorld
cd HelloWorld
dotnet run

dotnet add package Dapper
dotnet add package microsoft.data.sqlclient

dotnet add package microsoft.entityframeworkcore
dotnet add package microsoft.entityframeworkcore.sqlserver

code .
```



## Error converting data type varchar to numeric [31]
## Dapper Pt 1 [32]
## Dapper Pt 2 [33]
## Entity Framework [34]
## Config [35]
## Intermediate Theory Pt 2 [36]
## File Read and Write [37]
## JSON [38]
## Model Mapping [39]
## Skipping Crash Course [40]
## MacOS and Linux Users [41]
## SQL Seed [42]
## SQL - Basics Pt1 [43]
## SQL - Basics Pt2 [44]
## SQL - Intermediate [45]
## API Basics Theory [46]
## .NET 7 default run [47]
## Getting Started [48]
## Startup.cs [49]
## First Custom Controller [50]
## .NET 7 launchSettings.json [51]
## API Setup [52]
## MacOS and Linux Users [53]
## Database Connection [54]
## Http Launch [55]
## User Models [56]
## Users Controller [57]
## Put & Post [58]
## DTOs [59]
## Namespaces [60]
## User Delete [61]
## EF Setup [62]
## EF User Controller [63]
## AutoMapper [64]
## Beginner Assignment [65]
## Beginner Assignment Solution Dapper [66]
## Beginner Assignment Solution Entity Framework [67]
## API Intermediate Theory [68]
## UserRepository [69]
## IUserRepository [70]
## Repository Peripherals [71]
## Auth Table SQL [72]
## Auth Settings and Models [73]
## Password Managment [74]
## Login [75]
## Registration With Details [76]
## .NET 7 Note - IConfiguration.GetSection() [77]
## JWT Token Creation [78]
## JWT Token Validation [79]
## Helpers [80]
## Posts Model [81]
## Posts Controller [82]
## Posts Search [83]
## Stored Procedure Creation [84]
## Parameters [85]
## Nullable Parameters [86]
## Join and Outer Apply [87]
## Temp Table [88]
## User Upsert [89]
## User Upsert Peripherals [90]
## User Delete [91]
## Posts Get [92]
## Post Upsert [93]
## Post Delete [94]
## Auth [95]
## API Advanced Theory [96]
## Stored Procedures Script [97]
## UserComplete Setup and Get [98]
## UserComplete Upsert [99]
## User Delete [100]
## Posts Get [101]
## My Posts [102]
## Post Upsert [103]
## Post Delete [104]
## Auth Register [105]
## Reset Password [106]
## Login [107]
## Cleanup [108]
## User Controller DynamicParameters [109]
## Advanced Assignment [110]
## Advanced Assignment Solution [111]
## Reusable SQL [112]
## Azure App Service [113]
## Azure Database Creation [114]
## Azure SQL Seed [115]
## Azure Database Connection [116]
## Azure Deploy with Database Connection [117]
## Delete Azure Resources [118]
## Congratulations! [119]