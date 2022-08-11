using System;

public class OracleDb : IDatabaseConnection{

	public string connectionString {get; set;}

	public OracleDb(DatabaseConfig dbConfig){
		this.connectionString = dbConfig.connectionString;
	}
} 
