using System;
namespace DatabaseConnection;

public class MysqlDb : IDatabaseConnection
{
	public string _connectionString;

	public string ConnectionString { get { return _connectionString; } set { _connectionString = value; }}

	public MysqlDb(DatabaseConfig dbConfig){
		_connectionString = dbConfig.connectionString;
	}
} 
