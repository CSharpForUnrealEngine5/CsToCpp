#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGrassType.h")]
public partial class ULandscapeGrassType : UObject {
// LandscapeGrassType
	public TArray<FGrassVariety> GrassVarieties;
	public bool bEnableDensityScaling;
	public UStaticMesh GrassMesh_DEPRECATED;
	public float GrassDensity_DEPRECATED;
	public float PlacementJitter_DEPRECATED;
	public int StartCullDistance_DEPRECATED;
	public int EndCullDistance_DEPRECATED;
	public bool RandomRotation_DEPRECATED;
	public bool AlignToSurface_DEPRECATED;
}
