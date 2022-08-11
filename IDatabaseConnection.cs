using System;
namespace DatabaseConnection;



public interface IDatabaseConnection
{
    public string connectionString { get; set; }
}
