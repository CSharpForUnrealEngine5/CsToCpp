namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Level.h")]
public partial struct FLevelSimplificationDetails {
	public bool bCreatePackagePerAsset;
	public float DetailsPercentage;
	public FMaterialProxySettings StaticMeshMaterialSettings;
	public bool bOverrideLandscapeExportLOD;
	public int LandscapeExportLOD;
	public FMaterialProxySettings LandscapeMaterialSettings;
	public bool bBakeFoliageToLandscape;
	public bool bBakeGrassToLandscape;
}
