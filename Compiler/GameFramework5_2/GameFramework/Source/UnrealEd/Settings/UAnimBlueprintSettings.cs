#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/AnimBlueprintSettings.h")]
///<summary>Implements Editor settings for animation blueprints</summary>
public partial class UAnimBlueprintSettings : UObject {
// AnimBlueprintSettings
	public bool bAllowEventGraphs;
	public bool bAllowMacros;
	public bool bAllowDelegates;
	public bool bRestrictBaseFunctionOverrides;
	public TArray<string> BaseFunctionOverrideAllowList;
}
