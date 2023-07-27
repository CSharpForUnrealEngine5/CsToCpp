#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_CreateNewAssetFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_CreateNewAssetFunctions
	public static void CreateUniqueNewAssetPathName(string AssetFolderPath,string BaseAssetName,string UniqueAssetPathAndName,string UniqueAssetName,FGeometryScriptUniqueAssetNameOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	public static AVolume CreateNewVolumeFromMesh(UDynamicMesh FromDynamicMesh,UWorld CreateInWorld,FTransform ActorTransform,string BaseActorName,FGeometryScriptCreateNewVolumeFromMeshOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UStaticMesh CreateNewStaticMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,string AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static USkeletalMesh CreateNewSkeletalMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,USkeleton InSkeleton,string AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UTexture2D CreateNewTexture2DAsset(UTexture2D FromTexture,string AssetPathAndName,FGeometryScriptCreateNewTexture2DAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
