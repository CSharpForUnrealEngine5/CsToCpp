#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitVideoOverlay.h")]
///<summary>Helper class to ensure the ARKit camera material is cooked.</summary>
public partial class UARKitCameraOverlayMaterialLoader : UObject {
// ARKitCameraOverlayMaterialLoader
	public UMaterialInterface DefaultCameraOverlayMaterial;
	public UMaterialInterface DepthOcclusionOverlayMaterial;
	public UMaterialInterface MatteOcclusionOverlayMaterial;
	public UMaterialInterface SceneDepthOcclusionMaterial;
	public UMaterialInterface SceneDepthColorationMaterial;
}
