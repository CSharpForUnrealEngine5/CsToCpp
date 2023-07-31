#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SearchUserSettings.h")]
public partial class USearchUserSettings : UDeveloperSettings {
	///<summary>Enable this to begin using search.</summary>
	public bool bEnableSearch;
	///<summary>IgnoredPaths</summary>
	public TArray<FDirectoryPath> IgnoredPaths;
	///<summary>bShowMissingAssets</summary>
	public bool bShowMissingAssets;
	///<summary>bAutoExpandAssets</summary>
	public bool bAutoExpandAssets;
	///<summary>bThrottleInBackground</summary>
	public bool bThrottleInBackground;
	///<summary>DefaultOptions</summary>
	public FSearchPerformance DefaultOptions;
	///<summary>BackgroundtOptions</summary>
	public FSearchPerformance BackgroundtOptions;
	///<summary>SearchInForeground</summary>
	public int SearchInForeground;
}
