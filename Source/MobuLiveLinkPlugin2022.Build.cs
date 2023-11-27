// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class MobuLiveLinkPlugin2022 : MobuLiveLinkPluginBase
{
	public MobuLiveLinkPlugin2022(ReadOnlyTargetRules Target) : base(Target, "2022")
	{
		CppStandard = CppStandardVersion.Cpp17;

		// Replace with PCHUsageMode.UseExplicitOrSharedPCHs when this plugin can compile with cpp20
		PCHUsage = PCHUsageMode.NoPCHs;
	}
}
