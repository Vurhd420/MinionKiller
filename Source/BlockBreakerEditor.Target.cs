// I completely copied paragon minions so I definintly have the rights to sell this

using UnrealBuildTool;
using System.Collections.Generic;

public class BlockBreakerEditorTarget : TargetRules
{
	public BlockBreakerEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "BlockBreaker" } );
	}
}
