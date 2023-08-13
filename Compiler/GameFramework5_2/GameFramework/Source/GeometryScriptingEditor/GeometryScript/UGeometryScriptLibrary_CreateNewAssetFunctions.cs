namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/CreateNewAssetUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_CreateNewAssetFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CreateUniqueNewAssetPathName</summary>
	public static void CreateUniqueNewAssetPathName(string AssetFolderPath,string BaseAssetName,string UniqueAssetPathAndName,string UniqueAssetName,FGeometryScriptUniqueAssetNameOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>CreateNewVolumeFromMesh</summary>
	public static AVolume CreateNewVolumeFromMesh(UDynamicMesh FromDynamicMesh,UWorld CreateInWorld,FTransform ActorTransform,string BaseActorName,FGeometryScriptCreateNewVolumeFromMeshOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CreateNewStaticMeshAssetFromMesh</summary>
	public static UStaticMesh CreateNewStaticMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,string AssetPathAndName,FGeometryScriptCreateNewStaticMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CreateNewSkeletalMeshAssetFromMesh</summary>
	public static USkeletalMesh CreateNewSkeletalMeshAssetFromMesh(UDynamicMesh FromDynamicMesh,USkeleton InSkeleton,string AssetPathAndName,FGeometryScriptCreateNewSkeletalMeshAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CreateNewTexture2DAsset</summary>
	public static UTexture2D CreateNewTexture2DAsset(UTexture2D FromTexture,string AssetPathAndName,FGeometryScriptCreateNewTexture2DAssetOptions Options,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
