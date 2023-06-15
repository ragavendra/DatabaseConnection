using System;
namespace DatabaseConnection;

public class OracleDb : IDatabaseConnection
{
	public string _connectionString;

	public string ConnectionString { get { return _connectionString; } set { _connectionString = value; }}

	public OracleDb(DatabaseConfig dbConfig){
		_connectionString = dbConfig.connectionString;
	}
}