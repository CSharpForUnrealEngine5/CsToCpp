#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterMeshComponent.h")]
///<summary>Water Mesh Component responsible for generating and rendering a continuous water mesh on top of all the existing water body actors in the world</summary>
public partial class UWaterMeshComponent : UMeshComponent {
// WaterMeshComponent
	public int ForceCollapseDensityLevel;
	public UMaterialInterface FarDistanceMaterial;
	public float FarDistanceMeshExtent;
	public  bool IsEnabled() { return default; }
	public float TileSize;
	public FIntPoint ExtentInTiles;
	public TSet<UMaterialInterface> UsedMaterials;
	public bool bUseFarMeshWithoutOcean;
	public int TessellationFactor;
	public float LODScale;
}
