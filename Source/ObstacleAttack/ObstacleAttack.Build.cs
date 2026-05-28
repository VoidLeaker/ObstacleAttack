// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObstacleAttack : ModuleRules
{
	public ObstacleAttack(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObstacleAttack",
			"ObstacleAttack/Variant_Platforming",
			"ObstacleAttack/Variant_Platforming/Animation",
			"ObstacleAttack/Variant_Combat",
			"ObstacleAttack/Variant_Combat/AI",
			"ObstacleAttack/Variant_Combat/Animation",
			"ObstacleAttack/Variant_Combat/Gameplay",
			"ObstacleAttack/Variant_Combat/Interfaces",
			"ObstacleAttack/Variant_Combat/UI",
			"ObstacleAttack/Variant_SideScrolling",
			"ObstacleAttack/Variant_SideScrolling/AI",
			"ObstacleAttack/Variant_SideScrolling/Gameplay",
			"ObstacleAttack/Variant_SideScrolling/Interfaces",
			"ObstacleAttack/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
