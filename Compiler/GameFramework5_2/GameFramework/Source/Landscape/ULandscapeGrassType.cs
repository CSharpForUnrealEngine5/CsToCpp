#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGrassType.h")]
public partial class ULandscapeGrassType : UObject {
	///<summary>GrassVarieties</summary>
	public TArray<FGrassVariety> GrassVarieties;
	///<summary>Whether this grass type should be affected by the Engine Scalability system&#39;s Foliage grass.DensityScale setting.</summary>
	public bool bEnableDensityScaling;
	///<summary>GrassMesh_DEPRECATED</summary>
	public UStaticMesh GrassMesh_DEPRECATED;
	///<summary>GrassDensity_DEPRECATED</summary>
	public float GrassDensity_DEPRECATED;
	///<summary>PlacementJitter_DEPRECATED</summary>
	public float PlacementJitter_DEPRECATED;
	///<summary>StartCullDistance_DEPRECATED</summary>
	public int StartCullDistance_DEPRECATED;
	///<summary>EndCullDistance_DEPRECATED</summary>
	public int EndCullDistance_DEPRECATED;
	///<summary>RandomRotation_DEPRECATED</summary>
	public bool RandomRotation_DEPRECATED;
	///<summary>AlignToSurface_DEPRECATED</summary>
	public bool AlignToSurface_DEPRECATED;
}
