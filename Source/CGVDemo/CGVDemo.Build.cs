// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CGVDemo : ModuleRules
{
	public CGVDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		PublicDependencyModuleNames.AddRange(new string[]
			{ "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay"});
	}
}