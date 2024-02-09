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

