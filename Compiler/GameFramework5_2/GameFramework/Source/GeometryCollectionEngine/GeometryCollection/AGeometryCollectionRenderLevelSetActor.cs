#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionRenderLevelSetActor.h")]
///<summary>AGeometryCollectionRenderLevelSetActor</summary>
public partial class AGeometryCollectionRenderLevelSetActor : AActor {
// GeometryCollectionRenderLevelSetActor
	public UVolumeTexture TargetVolumeTexture;
	public UMaterial RayMarchMaterial;
	public float SurfaceTolerance;
	public float Isovalue;
	public bool Enabled;
	public bool RenderVolumeBoundingBox;
}
