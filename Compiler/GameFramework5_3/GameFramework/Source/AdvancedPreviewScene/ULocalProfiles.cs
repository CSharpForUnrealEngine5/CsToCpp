namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetViewerSettings.h")]
public partial class ULocalProfiles : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection of local scene profiles</summary>
	public TArray<FPreviewSceneProfile> Profiles;
}
