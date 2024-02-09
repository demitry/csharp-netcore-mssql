// See https://aka.ms/new-console-template for more information
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

//For Windows
string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";

//For Linux and MacOS
// string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1";

IDbConnection dbConnection = new SqlConnection(connectionString);

string sqlCommand = "SELECT GETDATE()";

DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
Console.WriteLine(rightNow);

Computer computer = new()
{
    ComputerId = 1,
    Motherboard = "ASUS Prime Z390-A",
    CPUCores = 8,
    HasWifi = true,
    HasLTE = false,
    ReleaseDate = new DateTime(2019, 1, 1),
    Price = 1500.00M,
    VideoCard = "NVIDIA GeForce RTX 2080"
};

string insertQuery = @"INSERT INTO TutorialAppSchema.Computer 
                       (Motherboard, CPUCores, HasWifi, HasLTE, ReleaseDate, Price, VideoCard) 
                       VALUES (@Motherboard, @CPUCores, @HasWifi, @HasLTE, @ReleaseDate, @Price, @VideoCard)";

dbConnection.Execute(insertQuery, computer);
