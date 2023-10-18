namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_CreateNewAssetFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CreateUniqueNewAssetPathName</summary>
	public static void CreateUniqueNewAssetPathName(string AssetFolderPath,string BaseAssetName,string UniqueAssetPathAndName,string UniqueAssetName,FGeometryScriptUniqueAssetNameOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>CreateNewVolumeFromMesh</summary>
	public static AVolume CreateNewVolumeFromMesh(UDynamicMesh FromDynamicMesh,UWorld CreateInWorld,FTransform ActorTransform,string BaseActorName,FGeometryScriptCreateNewVolumeFromMeshOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new StaticMesh asset from a DynamicMesh. Save the asset at the AssetPathAndName location.</summary>
	public static UStaticMesh CreateNewStaticMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,string AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new StaticMesh asset from a collection of LODs represented by an array of DynamicMeshes.</summary>
	public static UStaticMesh CreateNewStaticMeshAssetFromMeshLODs(TArray<UDynamicMesh> FromDynamicMesh,string AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new SkeletalMesh asset from a DynamicMesh and a Skeleton.</summary>
	public static USkeletalMesh CreateNewSkeletalMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,USkeleton InSkeleton,string AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a new SkeletalMesh asset from a collection of LODs represented by an array of DynamicMeshes and a Skeleton.</summary>
	public static USkeletalMesh CreateNewSkeletalMeshAssetFromMeshLODs(TArray<UDynamicMesh> FromDynamicMeshLODs,USkeleton InSkeleton,string AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CreateNewTexture2DAsset</summary>
	public static UTexture2D CreateNewTexture2DAsset(UTexture2D FromTexture,string AssetPathAndName,FGeometryScriptCreateNewTexture2DAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
