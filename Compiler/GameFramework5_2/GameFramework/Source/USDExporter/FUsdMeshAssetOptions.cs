namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetOptions.h")]
public partial struct FUsdMeshAssetOptions {
	public bool bUsePayload;
	public string PayloadFormat;
	public bool bBakeMaterials;
	public bool bRemoveUnrealMaterials;
	public FUsdMaterialBakingOptions MaterialBakingOptions;
	public int LowestMeshLOD;
	public int HighestMeshLOD;
}
