// © 2017 Etherealms - MEdmonds

using UnrealBuildTool;
using System.Collections.Generic;

public class MyBattleTankEditorTarget : TargetRules
{
	public MyBattleTankEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MyBattleTank" } );
	}
}
