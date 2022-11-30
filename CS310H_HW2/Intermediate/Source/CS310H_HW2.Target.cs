using UnrealBuildTool;

public class CS310H_HW2Target : TargetRules
{
	public CS310H_HW2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CS310H_HW2");
	}
}
