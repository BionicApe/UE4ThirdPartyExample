//// Copyright Epic Games, Inc. All Rights Reserved.

//using UnrealBuildTool;

//public class ThePrisonDAO : ModuleRules
//{
//    public ThePrisonDAO(ReadOnlyTargetRules Target) : base(Target)
//    {
//        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

//        PublicIncludePaths.AddRange(
//            new string[]
//            {
//                "$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/jdbc/",
//                "$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/mysql/",
//                "$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/",
//                "$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/mysqlx/"
//            }
//            );


//        PrivateIncludePaths.AddRange(
//            new string[]
//            {
//                //"$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/jdbc/",
//                //"$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/mysql/",
//                //"$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/include/mysqlx/"
//            }
//            );


//        PublicDependencyModuleNames.AddRange(
//            new string[]
//            {
//                "Core",
//                "Engine",
//                "CoreUObject",
//                "InputCore",
//                "Projects",
//                "MySQLConnectorLibrary",
//				// ... add other public dependencies that you statically link with here ...
//			}
//            );


//        PrivateDependencyModuleNames.AddRange(
//            new string[]
//            {
//				// ... add private dependencies that you statically link with here ...	
//			}
//            );

//        DynamicallyLoadedModuleNames.AddRange(
//            new string[]
//            {
//            }
//            );
//    }
//}
