namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetViewerSettings.h")]
public partial class USharedProfiles : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection of shared scene profiles</summary>
	public TArray<FPreviewSceneProfile> Profiles;
}
