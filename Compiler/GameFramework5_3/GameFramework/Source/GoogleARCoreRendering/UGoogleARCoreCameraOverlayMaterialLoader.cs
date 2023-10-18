namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper class that is used to load the GoogleARCorePassthroughCameraMaterial from its default object.</summary>
[CppInclude("GoogleARCorePassthroughCameraRenderer.h")]
public partial class UGoogleARCoreCameraOverlayMaterialLoader : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A pointer to the camera overlay material that will be used to render the passthrough camera texture as background.</summary>
	public UMaterialInterface RegularOverlayMaterial;
	///<summary>A pointer to the camera overlay material that will be used to render the passthrough camera texture as background.</summary>
	public UMaterialInterface DebugOverlayMaterial;
	///<summary>DepthOcclusionMaterial</summary>
	public UMaterialInterface DepthOcclusionMaterial;
	///<summary>Material used for rendering the coloration of the depth map.</summary>
	public UMaterialInterface DepthColorationMaterial;
}
