//// Created by Bionic Ape. All Rights Reserved.

//using System.IO;
//using UnrealBuildTool;

//public class MySQLConnectorLibrary : ModuleRules
//{
//    public MySQLConnectorLibrary(ReadOnlyTargetRules Target) : base(Target)
//    {
//        Type = ModuleType.External;

//        string IncludePath = Path.Combine(ModuleDirectory, "include");

//        PublicIncludePaths.Add(IncludePath);


//        // Add any macros that need to be set
//        PublicDefinitions.Add("WITH_MYSQL=1");
        
//        PublicDefinitions.Add("MYSQL_CONCPP_DIR=" + ModuleDirectory);
//        PublicDefinitions.Add("CPPFLAGS=-I $(MYSQL_CONCPP_DIR)/include -L $(MYSQL_CONCPP_DIR)/lib64=0");
//        PublicDefinitions.Add("LDLIBS = -lmysqlcppconn");

//        // Add any include paths for the plugin

//        if (Target.Platform == UnrealTargetPlatform.Win64)
//        {

//            //Add the import libraries

//            // string LibrariesPath = Path.Combine(ModuleDirectory, "debug", "lib");//Debug
//            // string DLLsPath = Path.Combine(ModuleDirectory, "debug", "bin");//Debug
//			string LibrariesPath = Path.Combine(ModuleDirectory, "lib64","vs14");//Shipping
//            string DLLsPath = Path.Combine(ModuleDirectory, "bin64");//Shipping
			
//            {
//                string LibraryPath = Path.Combine(LibrariesPath, "libcrypto.lib");
//                PublicAdditionalLibraries.Add(LibraryPath);
//                PublicDelayLoadDLLs.Add("libcrypto-1_1-x64.dll");
//                string DllPath = Path.Combine(DLLsPath, "libcrypto-1_1-x64.dll");
//                //RuntimeDependencies.Add(DllPath, StagedFileType.NonUFS);
//                //RuntimeDependencies.Add(Path.ChangeExtension(DllPath, ".pdb"), StagedFileType.DebugNonUFS);
//            }
//            {
//                string LibraryPath = Path.Combine(LibrariesPath, "libssl.lib");
//                PublicAdditionalLibraries.Add(LibraryPath);
//                PublicDelayLoadDLLs.Add("libssl-1_1-x64.dll");
//                string DllPath = Path.Combine(DLLsPath, "libssl-1_1-x64.dll");
//                //RuntimeDependencies.Add(DllPath, StagedFileType.NonUFS);
//                //RuntimeDependencies.Add(Path.ChangeExtension(DllPath, ".pdb"), StagedFileType.DebugNonUFS);
//            }
//            //{
//            //    string LibraryPath = Path.Combine(LibrariesPath, "mysqlcppconn.lib");
//            //    PublicAdditionalLibraries.Add(LibraryPath);
//            //}
//            {
//                string LibraryPath = Path.Combine(LibrariesPath, "mysqlcppconn8.lib");
//                PublicAdditionalLibraries.Add(LibraryPath);
//                PublicDelayLoadDLLs.Add("mysqlcppconn8-2-vs14.dll");
//                string DllPath = Path.Combine(DLLsPath, "mysqlcppconn8-2-vs14.dll");
//                RuntimeDependencies.Add(DllPath, StagedFileType.NonUFS);
//            }
//            //{
//            //    string LibraryPath = Path.Combine(LibrariesPath, "mysqlcppconn8-static.lib");
//            //    PublicAdditionalLibraries.Add(LibraryPath);
//            //}

//            string CrtPath = Path.Combine(EngineDirectory, "Binaries", "ThirdParty", "AppLocalDependencies", "Win64", "UCRT");

//            var CrtFiles = Directory.EnumerateFiles(CrtPath, "*.dll", SearchOption.AllDirectories);
//            foreach (string CrtDllPath in CrtFiles)
//            {
//                PublicDelayLoadDLLs.Add(Path.GetFileName(CrtDllPath));
//                RuntimeDependencies.Add(CrtDllPath, StagedFileType.NonUFS);
//            }


//        }
//        else if (Target.Platform == UnrealTargetPlatform.Mac)
//        {
//            //Wait until I own a Mac
//            PublicDelayLoadDLLs.Add(Path.Combine(ModuleDirectory, "Mac", "Release", "libExampleLibrary.dylib"));
//            //RuntimeDependencies.Add("$(PluginDir)/Source/ThirdParty/MySQLConnectorLibrary/Mac/Release/libExampleLibrary.dylib");
//        }
//    }
//}
