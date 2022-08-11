using System;
namespace DatabaseConnection;

//this class tries to show the implementation of conn to a db
public class User{

	//public string connectionString {get; set;}
	public static void Main(){

		DatabaseConfig dbConfig = new DatabaseConfig();
		MySQLDb mysqlDb = new MySQLDb (dbConfig);
		/*
		mysqlDb.Connect();
		var result = mysqlDb.RunSQL("SELCT * FROM tablename WHERE columnvalue = \'somevalue\'");
		*/
		//
		//
		//
	}
} 
