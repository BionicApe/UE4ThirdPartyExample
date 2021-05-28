// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "Modules/ModuleManager.h"
#include "CoreMinimal.h"
//#include "aws/core/Aws.h"

struct ThePrisonDAOLibraryHelper
{
	FString LibraryName;
	FString LibraryPath;
	void* Handle;
};

class FThePrisonDAOModule : public IModuleInterface
{

private:

	//Aws::LoggingOptions LogOpts;
	
	static TArray<ThePrisonDAOLibraryHelper> Libraries;

public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
