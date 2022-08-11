using System;

public class POSGresDb : IDatabaseConnection{

	public string connectionString {get; set;}

	public POSGresDb(DatabaseConfig dbConfig){
		this.connectionString = dbConfig.connectionString;
	}
} 
