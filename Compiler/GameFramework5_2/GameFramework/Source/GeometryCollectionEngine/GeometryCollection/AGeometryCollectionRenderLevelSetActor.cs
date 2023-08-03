#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AGeometryCollectionRenderLevelSetActor</summary>
[CppInclude("GeometryCollection/GeometryCollectionRenderLevelSetActor.h")]
public partial class AGeometryCollectionRenderLevelSetActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Volume texture to fill</summary>
	public UVolumeTexture TargetVolumeTexture;
	///<summary>Material that performs ray marching.  Note this must have certain parameters in order</summary>
	public UMaterial RayMarchMaterial;
	///<summary>Surface tolerance used for rendering.  When surface reconstruction is noisy,</summary>
	public float SurfaceTolerance;
	///<summary>Isovalue of the level set to use for surface reconstruction.  Generally you want</summary>
	public float Isovalue;
	///<summary>Enable or disable rendering</summary>
	public bool Enabled;
	///<summary>Enable or disable rendering</summary>
	public bool RenderVolumeBoundingBox;
}
