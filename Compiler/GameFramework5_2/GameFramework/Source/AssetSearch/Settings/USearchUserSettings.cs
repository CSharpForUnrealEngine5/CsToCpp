#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SearchUserSettings.h")]
public partial class USearchUserSettings : UDeveloperSettings {
// SearchUserSettings
	public bool bEnableSearch;
	public TArray<FDirectoryPath> IgnoredPaths;
	public bool bShowMissingAssets;
	public bool bAutoExpandAssets;
	public bool bThrottleInBackground;
	public FSearchPerformance DefaultOptions;
	public FSearchPerformance BackgroundtOptions;
	public int SearchInForeground;
}
