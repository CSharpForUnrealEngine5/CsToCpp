namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/WorldThumbnailInfo.h")]
public partial class UWorldThumbnailInfo : USceneThumbnailInfo {
	public static UClass StaticClass() {return default;}
	///<summary>The type of projection to use</summary>
	public ECameraProjectionMode CameraMode;
	///<summary>The direction of the camera when in Orthographic CameraMode</summary>
	public EOrthoThumbnailDirection OrthoDirection;
}
