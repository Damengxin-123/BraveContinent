using UnrealBuildTool;

/// <summary>游戏主模块的依赖与编译配置。</summary>
public class BraveContinent : ModuleRules
{
	/// <summary>配置 C++ 游戏逻辑使用的基础引擎模块。</summary>
	public BraveContinent(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
