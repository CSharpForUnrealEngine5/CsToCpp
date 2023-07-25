#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithScene.h")]
public partial class UDatasmithScene : UObject {
// DatasmithScene
	public UDatasmithSceneImportData AssetImportData;
	public int BulkDataVersion;
	public TMap<string,TSoftObjectPtr<UStaticMesh>> StaticMeshes;
	public TMap<string,TSoftObjectPtr<UObject>> Clothes;
	public TMap<string,TSoftObjectPtr<UTexture>> Textures;
	public TMap<string,TSoftObjectPtr<UMaterialFunction>> MaterialFunctions;
	public TMap<string,TSoftObjectPtr<UMaterialInterface>> Materials;
	public TMap<string,TSoftObjectPtr<ULevelSequence>> LevelSequences;
	public TMap<string,TSoftObjectPtr<ULevelVariantSets>> LevelVariantSets;
	public TArray<UAssetUserData> AssetUserData;
}
