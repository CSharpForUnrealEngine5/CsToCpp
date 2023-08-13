namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraRigsSettings.h")]
public partial class UCineCameraRigRailSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultSplineMeshMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultSplineMeshMaterial;
	///<summary>DefaultSplineMeshTexture</summary>
	public TSoftObjectPtr<UTexture2D> DefaultSplineMeshTexture;
}
