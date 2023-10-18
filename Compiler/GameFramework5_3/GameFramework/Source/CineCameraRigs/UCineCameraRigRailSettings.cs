namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraRigsSettings.h")]
public partial class UCineCameraRigRailSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Path to the default spline mesh material used in CineCameraRigRail</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultSplineMeshMaterial;
	///<summary>Path to the default spline mesh texture used when speed visualization is off</summary>
	public TSoftObjectPtr<UTexture2D> DefaultSplineMeshTexture;
	///<summary>Path to the texture used in the speed visualization when drive mode is Speed</summary>
	public TSoftObjectPtr<UTexture2D> SpeedModeSplineMeshTexture;
}
