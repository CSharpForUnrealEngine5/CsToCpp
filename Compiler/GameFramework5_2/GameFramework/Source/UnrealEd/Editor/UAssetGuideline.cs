#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>User data that can be attached to assets to check on load for guidlelines (plugins, project settings, etc).</summary>
[CppInclude("Editor/AssetGuideline.h")]
public partial class UAssetGuideline : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Plugins to check for on load</summary>
	public TArray<string> Plugins;
	///<summary>Project settings to check for on load. Look at your .ini&#39;s to populate this.</summary>
	public TArray<FIniStringValue> ProjectSettings;
	///<summary>Name of this guideline, we will only check once per unique guideline name.</summary>
	public string GuidelineName;
}
