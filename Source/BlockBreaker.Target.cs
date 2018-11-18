// I completely copied paragon minions so I definintly have the rights to sell this

using UnrealBuildTool;
using System.Collections.Generic;

public class BlockBreakerTarget : TargetRules
{
	public BlockBreakerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "BlockBreaker" } );
	}
}
