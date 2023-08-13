namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Water Mesh Component responsible for generating and rendering a continuous water mesh on top of all the existing water body actors in the world</summary>
[CppInclude("WaterMeshComponent.h")]
public partial class UWaterMeshComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>At above what density level a tile is allowed to force collapse even if not all leaf nodes in the subtree are present.</summary>
	public int ForceCollapseDensityLevel;
	///<summary>FarDistanceMaterial</summary>
	public UMaterialInterface FarDistanceMaterial;
	///<summary>FarDistanceMeshExtent</summary>
	public float FarDistanceMeshExtent;
	///<summary>IsEnabled</summary>
	public bool IsEnabled() { return default; }
	///<summary>World size of the water tiles at LOD0. Multiply this with the ExtentInTiles to get the world extents of the system</summary>
	public float TileSize;
	///<summary>The extent of the system in number of tiles. Maximum number of tiles for this system will be ExtentInTiles.X*2*ExtentInTiles.Y*2</summary>
	public FIntPoint ExtentInTiles;
	///<summary>Unique list of materials used by this component</summary>
	public TSet<UMaterialInterface> UsedMaterials;
	///<summary>Forces the water mesh to always render the far mesh, regardless if there is an ocean or not.</summary>
	public bool bUseFarMeshWithoutOcean;
	///<summary>Highest tessellation factor of a water tile. Max number of verts on the side of a tile will be (2^TessellationFactor)+1)</summary>
	public int TessellationFactor;
	///<summary>World scale of the concentric LODs</summary>
	public float LODScale;
}
