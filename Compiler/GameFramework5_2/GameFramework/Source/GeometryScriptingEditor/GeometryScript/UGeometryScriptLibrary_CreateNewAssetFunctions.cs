#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_CreateNewAssetFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_CreateNewAssetFunctions
	public void CreateUniqueNewAssetPathName(string AssetFolderPath,string BaseAssetName,string UniqueAssetPathAndName,string UniqueAssetName,FGeometryScriptUniqueAssetNameOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) {}
	public UObject CreateNewVolumeFromMesh(UObject FromDynamicMesh,UObject CreateInWorld,FTransform ActorTransform,string BaseActorName,FGeometryScriptCreateNewVolumeFromMeshOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject CreateNewStaticMeshAssetFromMesh(UObject FromDynamicMesh,string AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject CreateNewSkeletalMeshAssetFromMesh(UObject FromDynamicMesh,UObject InSkeleton,string AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject CreateNewTexture2DAsset(UObject FromTexture,string AssetPathAndName,FGeometryScriptCreateNewTexture2DAssetOptions Options,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
}
