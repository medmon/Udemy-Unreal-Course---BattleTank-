// © 2017 Etherealms - MEdmonds

using UnrealBuildTool;
using System.Collections.Generic;

public class MyBattleTankTarget : TargetRules
{
	public MyBattleTankTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MyBattleTank" } );
	}
}
