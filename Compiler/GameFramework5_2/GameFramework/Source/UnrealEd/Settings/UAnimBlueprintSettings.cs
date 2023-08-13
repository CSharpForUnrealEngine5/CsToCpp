namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements Editor settings for animation blueprints</summary>
[CppInclude("Settings/AnimBlueprintSettings.h")]
public partial class UAnimBlueprintSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to allow event graphs to be created/displayed in animation blueprints</summary>
	public bool bAllowEventGraphs;
	///<summary>Whether to allow macros to be created/displayed in animation blueprints</summary>
	public bool bAllowMacros;
	///<summary>Whether to allow delegates to be created/displayed in animation blueprints</summary>
	public bool bAllowDelegates;
	///<summary>Whether to allow restrict which base function overrides can created/displayed in animation blueprints</summary>
	public bool bRestrictBaseFunctionOverrides;
	///<summary>The set of allowed base functions if restricted</summary>
	public TArray<string> BaseFunctionOverrideAllowList;
}
