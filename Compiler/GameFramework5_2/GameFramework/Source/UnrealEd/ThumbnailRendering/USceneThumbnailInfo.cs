namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/SceneThumbnailInfo.h")]
public partial class USceneThumbnailInfo : UThumbnailInfo {
	public static UClass StaticClass() {return default;}
	///<summary>The pitch of the orbit camera around the asset</summary>
	public float OrbitPitch;
	///<summary>The yaw of the orbit camera around the asset</summary>
	public float OrbitYaw;
	///<summary>The offset from the bounds sphere distance from the asset</summary>
	public float OrbitZoom;
}
