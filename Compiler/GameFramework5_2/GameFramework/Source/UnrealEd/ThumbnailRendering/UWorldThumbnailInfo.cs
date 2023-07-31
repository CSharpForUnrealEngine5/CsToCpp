#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/WorldThumbnailInfo.h")]
public partial class UWorldThumbnailInfo : USceneThumbnailInfo {
	///<summary>The type of projection to use</summary>
	public ECameraProjectionMode CameraMode;
	///<summary>The direction of the camera when in Orthographic CameraMode</summary>
	public EOrthoThumbnailDirection OrthoDirection;
}
