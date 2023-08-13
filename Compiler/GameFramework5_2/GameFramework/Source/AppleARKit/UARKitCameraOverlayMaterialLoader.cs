namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to ensure the ARKit camera material is cooked.</summary>
[CppInclude("AppleARKitVideoOverlay.h")]
public partial class UARKitCameraOverlayMaterialLoader : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultCameraOverlayMaterial</summary>
	public UMaterialInterface DefaultCameraOverlayMaterial;
	///<summary>DepthOcclusionOverlayMaterial</summary>
	public UMaterialInterface DepthOcclusionOverlayMaterial;
	///<summary>MatteOcclusionOverlayMaterial</summary>
	public UMaterialInterface MatteOcclusionOverlayMaterial;
	///<summary>SceneDepthOcclusionMaterial</summary>
	public UMaterialInterface SceneDepthOcclusionMaterial;
	///<summary>SceneDepthColorationMaterial</summary>
	public UMaterialInterface SceneDepthColorationMaterial;
}
