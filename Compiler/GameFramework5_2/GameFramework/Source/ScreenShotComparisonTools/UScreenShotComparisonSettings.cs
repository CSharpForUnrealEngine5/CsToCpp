#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScreenShotComparisonSettings.h")]
public partial class UScreenShotComparisonSettings : UObject {
	///<summary>if true, any checked-in test results for confidential platforms will be put under &lt;ProjectDir&gt;/Platforms/&lt;Platform&gt;/Test instead of &lt;ProjectDir&gt;/Test</summary>
	public bool bUseConfidentialPlatformPathsForSavedResults;
	///<summary>An array of entries that describe other platforms we can use for fallbacks when comparing screenshots</summary>
	public TArray<FScreenshotFallbackEntry> ScreenshotFallbackPlatforms;
}
