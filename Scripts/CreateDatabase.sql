-- IF DB_ID('DotNetCourseDatabase') IS NOT NULL
--    --code mine :)
--    print 'DotNetCourseDatabase db exists'
-- ELSE print 'DotNetCourseDatabase db NOT exists'

-- IF DB_ID('DotNetCourseDatabase') IS NOT NULL
--    DROP DATABASE DotNetCourseDatabase

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
