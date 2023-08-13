namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FUAssetMeta {
	public string assetID;
	public string assetName;
	public string assetType;
	public string assetSubType;
	public short assetTier;
	public string assetRootPath;
	public TArray<FMeshInfo> meshList;
	public TArray<string> foliageAssetPaths;
	public TArray<FMaterialInstanceInfo> materialInstances;
	public TArray<FTexturesList> textureSets;
	public TArray<FMasterMaterialInfo> masterMaterials;
}
