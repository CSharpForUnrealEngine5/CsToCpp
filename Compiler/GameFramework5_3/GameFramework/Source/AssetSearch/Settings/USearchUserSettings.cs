namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SearchUserSettings.h")]
public partial class USearchUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Enable this to begin using search.</summary>
	public bool bEnableSearch;
	///<summary>IgnoredPaths</summary>
	public TArray<FDirectoryPath> IgnoredPaths;
	///<summary>bShowAssetsNeedingIndexing</summary>
	public bool bShowAssetsNeedingIndexing;
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
