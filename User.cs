using System;
namespace DatabaseConnection;

//this class tries to show the implementation of conn to a db
public class User
{

	//public string connectionString {get; set;}
	public static void Main(){

		DatabaseConfig dbConfig = new DatabaseConfig();
		MysqlDb mysqlDb = new MysqlDb (dbConfig);
		/*
		mysqlDb.Connect();
		var result = mysqlDb.RunSQL("SELCT * FROM tablename WHERE columnvalue = \'somevalue\'");
		*/
		//
		//
		//
	}
} 
