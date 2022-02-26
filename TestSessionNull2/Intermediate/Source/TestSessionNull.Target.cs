using UnrealBuildTool;

public class TestSessionNullTarget : TargetRules
{
	public TestSessionNullTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TestSessionNull");
	}
}
