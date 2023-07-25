#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Level.h")]
public partial struct FLevelSimplificationDetails {
// LevelSimplificationDetails
	public bool bCreatePackagePerAsset;
	public float DetailsPercentage;
	public FMaterialProxySettings StaticMeshMaterialSettings;
	public bool bOverrideLandscapeExportLOD;
	public int LandscapeExportLOD;
	public FMaterialProxySettings LandscapeMaterialSettings;
	public bool bBakeFoliageToLandscape;
	public bool bBakeGrassToLandscape;
}
