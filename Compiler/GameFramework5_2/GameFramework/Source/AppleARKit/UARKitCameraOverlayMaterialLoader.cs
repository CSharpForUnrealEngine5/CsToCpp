#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to ensure the ARKit camera material is cooked.</summary>
[CppInclude("AppleARKitVideoOverlay.h")]
public partial class UARKitCameraOverlayMaterialLoader : UObject {
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
