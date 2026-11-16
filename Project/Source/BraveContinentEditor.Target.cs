using UnrealBuildTool;

/// <summary>BraveContinent 编辑器的构建目标。</summary>
public class BraveContinentEditorTarget : TargetRules
{
	/// <summary>配置虚幻 5.9 编辑器构建规则及主模块。</summary>
	public BraveContinentEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V8;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_9;
		ExtraModuleNames.Add("BraveContinent");
	}
}
