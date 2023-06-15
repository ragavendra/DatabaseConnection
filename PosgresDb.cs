using System;
namespace DatabaseConnection;

public class PosgresDb : IDatabaseConnection
{
	public string _connectionString;

	public string ConnectionString { get { return _connectionString; } set { _connectionString = value; }}

	public PosgresDb(DatabaseConfig dbConfig){
		_connectionString = dbConfig.connectionString;
	}
} 
