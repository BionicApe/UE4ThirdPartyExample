// Copyright Epic Games, Inc. All Rights Reserved.

#include "ThePrisonDAOModule.h"
#include "Core.h"
#include "Modules/ModuleManager.h"
#include "Interfaces/IPluginManager.h"


#define LOCTEXT_NAMESPACE "FThePrisonDAOModule"

#if PLATFORM_WINDOWS
TArray<ThePrisonDAOLibraryHelper> FThePrisonDAOModule::Libraries =
{
	{
		TEXT("zlib1"),
		TEXT("Source/ThirdParty/MySQLConnectorLibrary/bin/libcrypto-1_1-x64.dll"),
		nullptr
	},
	{
		TEXT("aws-c-common"),
		TEXT("Source/ThirdParty/MySQLConnectorLibrary/lib64/libssl-1_1-x64.dll"),
		nullptr
	},
	{
		TEXT("aws-checksums"),
		TEXT("Source/ThirdParty/MySQLConnectorLibrary/lib64/mysqlcppconn8-2-vs14.dll"),
		nullptr
	}
};
#elif PLATFORM_MAC

#endif // PLATFORM_WINDOWS


void FThePrisonDAOModule::StartupModule()
{

	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module

	// Get the base directory of this plugin
	FString BaseDir = IPluginManager::Get().FindPlugin("ThePrisonDAO")->GetBaseDir();

	// Add on the relative location of the third party dll and load it

	//for (ThePrisonDAOLibraryHelper Library : Libraries)
	//{
	//	FString const FullPath = FPaths::Combine(*BaseDir, *Library.LibraryPath);
	//	Library.Handle = !Library.LibraryPath.IsEmpty() ? FPlatformProcess::GetDllHandle(*FullPath) : nullptr;
	//	if (!Library.Handle)
	//	{
	//		FFormatNamedArguments Arguments;
	//		Arguments.Add(TEXT("Name"), FText::FromString(Library.LibraryName));
	//		Arguments.Add(TEXT("Path"), FText::FromString(FullPath));
	//		FMessageDialog::Open(EAppMsgType::Ok, FText::Format(LOCTEXT("LoadDependencyError", "Failed to load {Name} with Path: {Path} Plugin will not be functional"), Arguments));
	//	}
	//}
}

void FThePrisonDAOModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
	for (ThePrisonDAOLibraryHelper Library : Libraries)
	{
		FPlatformProcess::FreeDllHandle(Library.Handle);
		Library.Handle = nullptr;
	}
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FThePrisonDAOModule, ThePrisonDAO)