// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class MobuLiveLinkPlugin2023 : MobuLiveLinkPluginBase
{
	public MobuLiveLinkPlugin2023(ReadOnlyTargetRules Target) : base(Target, "2023")
	{
		CppStandard = CppStandardVersion.Cpp17;

		// Replace with PCHUsageMode.UseExplicitOrSharedPCHs when this plugin can compile with cpp20
		PCHUsage = PCHUsageMode.NoPCHs;
	}
}
