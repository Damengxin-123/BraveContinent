using UnrealBuildTool;

/// <summary>BraveContinent 游戏程序的构建目标。</summary>
public class BraveContinentTarget : TargetRules
{
	/// <summary>配置虚幻 5.9 游戏构建规则及主模块。</summary>
	public BraveContinentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V8;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_9;
		ExtraModuleNames.Add("BraveContinent");
	}
}
