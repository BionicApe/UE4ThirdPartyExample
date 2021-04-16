// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;

public class BAAwsSdkLibrary : ModuleRules
{
    public BAAwsSdkLibrary(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;


        // Add any macros that need to be set
        PublicDefinitions.Add("WITH_MYTHIRDPARTYLIBRARY=1");

        // Add any include paths for the plugin
        PublicIncludePaths.Add(ModuleDirectory);

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {

            // Add the import library
            string LibPath = Path.Combine(ModuleDirectory, "x64", "Release", "ExampleLibrary.lib");
            PublicAdditionalLibraries.Add(LibPath);

            // Delay-load the DLL, so we can load it from the right place first
            PublicDelayLoadDLLs.Add("ExampleLibrary.dll");

            // Ensure that the DLL is staged along with the executable
            RuntimeDependencies.Add("$(ModuleDir)/x64/Release/ExampleLibrary.dll");
            
        }
        else if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            PublicDelayLoadDLLs.Add(Path.Combine(ModuleDirectory, "Mac", "Release", "libExampleLibrary.dylib"));
            RuntimeDependencies.Add("$(PluginDir)/Source/ThirdParty/BAAwsSdkLibrary/Mac/Release/libExampleLibrary.dylib");
        }
    }
}
