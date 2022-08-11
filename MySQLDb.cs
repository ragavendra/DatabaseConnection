using System;
namespace DatabaseConnection;

public class MySQLDb : IDatabaseConnection{

	public string connectionString {get; set;}

	public MySQLDb(DatabaseConfig dbConfig){
		this.connectionString = dbConfig.connectionString;
	}
} 
