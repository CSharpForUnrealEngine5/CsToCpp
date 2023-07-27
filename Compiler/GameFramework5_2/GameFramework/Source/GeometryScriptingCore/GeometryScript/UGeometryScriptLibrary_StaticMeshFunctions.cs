#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
///<summary>Although the class name indicates StaticMeshFunctions, that was a naming mistake that is difficult</summary>
public partial class UGeometryScriptLibrary_StaticMeshFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_StaticMeshFunctions
	public static UDynamicMesh CopyMeshFromStaticMesh(UStaticMesh FromStaticMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshToStaticMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static void GetSectionMaterialListFromStaticMesh(UStaticMesh FromStaticMeshAsset,FGeometryScriptMeshReadLOD RequestedLOD,TArray<UMaterialInterface> MaterialList,TArray<int> MaterialIndex,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	public static UDynamicMesh CopyMeshFromSkeletalMesh(USkeletalMesh FromSkeletalMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshToSkeletalMesh(UDynamicMesh FromDynamicMesh,USkeletalMesh ToSkeletalMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
