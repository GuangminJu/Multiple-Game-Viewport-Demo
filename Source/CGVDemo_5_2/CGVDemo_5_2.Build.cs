// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CGVDemo_5_2 : ModuleRules
{
	public CGVDemo_5_2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
