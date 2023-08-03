#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/WorldThumbnailRenderer.h")]
public partial class UWorldThumbnailRenderer : UDefaultSizedThumbnailRenderer {
	public static UClass StaticClass() {return default;}
	///<summary>Offset used to orient all worlds to show a more vertical camera, if necessary. Individual thumbnail infos can provide additional offset.</summary>
	public float GlobalOrbitPitchOffset;
	///<summary>Offset used to orient all worlds to face the camera in degrees when using a perspective camera. Individual thumbnail infos can provide additional offset.</summary>
	public float GlobalOrbitYawOffset;
	///<summary>If true, all world thumbnails will be rendered unlit. This is useful in games that have shared lighting in a common map</summary>
	public bool bUseUnlitScene;
	///<summary>If false, all world thumbnails rendering will be disabled</summary>
	public bool bAllowWorldThumbnails;
}
