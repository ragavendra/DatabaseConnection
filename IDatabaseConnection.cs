using System;
namespace DatabaseConnection;



public interface IDatabaseConnection
{
    public string ConnectionString { get; set; }
}
