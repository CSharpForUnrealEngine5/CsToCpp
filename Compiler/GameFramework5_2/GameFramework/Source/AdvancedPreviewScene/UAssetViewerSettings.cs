namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default asset viewer settings.</summary>
[CppInclude("AssetViewerSettings.h")]
public partial class UAssetViewerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection of scene profiles</summary>
	public TArray<FPreviewSceneProfile> Profiles;
	///<summary>This will enforce mutable CDO of UAssetViewerSettings transacted</summary>
	public bool bFakeConfigValue_HACK;
}
