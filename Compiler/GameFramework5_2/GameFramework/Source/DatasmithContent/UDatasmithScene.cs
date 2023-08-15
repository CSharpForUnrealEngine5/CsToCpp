namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithScene.h")]
public partial class UDatasmithScene : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Importing data and options used for this Datasmith scene</summary>
	public UDatasmithSceneImportData AssetImportData;
	///<summary>BulkDataVersion</summary>
	public int BulkDataVersion;
	///<summary>Map of all the static meshes related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<UStaticMesh>> StaticMeshes;
	///<summary>Map of all the cloth related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<UObject>> Clothes;
	///<summary>Map of all the textures related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<UTexture>> Textures;
	///<summary>Map of all the material functions related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<UMaterialFunction>> MaterialFunctions;
	///<summary>Map of all the materials related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<UMaterialInterface>> Materials;
	///<summary>Map of all the level sequences related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<ULevelSequence>> LevelSequences;
	///<summary>Map of all the level variant sets related to this Datasmith Scene</summary>
	public TMap<FName,TSoftObjectPtr<ULevelVariantSets>> LevelVariantSets;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
