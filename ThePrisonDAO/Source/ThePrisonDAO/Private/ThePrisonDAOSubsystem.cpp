// Created by Bionic Ape. All Rights Reserved.


#include "ThePrisonDAOSubsystem.h"


THIRD_PARTY_INCLUDES_START
#include "Windows/WindowsPlatformProcess.h"
#include "cppconn/driver.h"
#include "cppconn/connection.h"
#include "cppconn/statement.h"
#include "cppconn/resultset.h"
//#include "mysql_connection.h"
//#include "cppconn/driver.h"
//#include "cppconn/exception.h"
//#include "cppconn/resultset.h"
//#include "cppconn/statement.h"
//#include <mysql/jdbc.h>
//#include <cppconn/driver.h>
THIRD_PARTY_INCLUDES_END


void UThePrisonDAOSubsystem::Initialize(FSubsystemCollectionBase& Collection)
{
	Super::Initialize(Collection);
}

void UThePrisonDAOSubsystem::Deinitialize()
{
	Super::Deinitialize();
}

void UThePrisonDAOSubsystem::ExecuteQuery()
{
	UE_LOG(LogTemp, Log, TEXT("UThePrisonDAOSubsystem::ExecuteQuery"));

	try {
		sql::Driver* driver;
		sql::Connection* con;
		sql::Statement* stmt;
		sql::ResultSet* res;

		/* Create a connection */
		driver = get_driver_instance();
		con = driver->connect(DatabaseURL, DatabaseUsername, DatabasePassword);
		stmt = con->createStatement();
		res = stmt->executeQuery("SELECT 'Hello World!' AS _message");
		
		while (res->next()) 
		{
			UE_LOG(LogTemp, Log, TEXT("\t... MySQL replies: "));
			UE_LOG(LogTemp, Log, TEXT("Message: %s"), UTF8_TO_TCHAR(res->getString("_message"));
		}

		delete res;
		delete stmt;
		delete con;

	}
	catch (sql::SQLException& e) {
		UE_LOG(LogTemp, Log, TEXT("# ERR: SQLException UThePrisonDAOSubsystem::ExecuteQuery"));
	}
	
	cout << endl;
}