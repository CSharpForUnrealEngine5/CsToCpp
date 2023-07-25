#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/ThumbnailManager.h")]
public partial class UThumbnailManager : UObject {
// ThumbnailManager
	public FThumbnailRenderingInfo NotSupported;
	public UStaticMesh EditorCube;
	public UStaticMesh EditorSphere;
	public UStaticMesh EditorCylinder;
	public UStaticMesh EditorPlane;
	public UStaticMesh EditorSkySphere;
	public UMaterial FloorPlaneMaterial;
	public UTextureCube AmbientCubemap;
	public UTexture2D CheckerboardTexture;
	public TArray<FThumbnailRenderingInfo> RenderableThumbnailTypes;
	public string ThumbnailManagerClassName;
}
