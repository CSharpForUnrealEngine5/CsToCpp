#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
///<summary>Although the class name indicates StaticMeshFunctions, that was a naming mistake that is difficult</summary>
public partial class UGeometryScriptLibrary_StaticMeshFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_StaticMeshFunctions
	public UObject CopyMeshFromStaticMesh(UObject FromStaticMeshAsset,UObject ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshToStaticMesh(UObject FromDynamicMesh,UObject ToStaticMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public void GetSectionMaterialListFromStaticMesh(UObject FromStaticMeshAsset,FGeometryScriptMeshReadLOD RequestedLOD,TArray<UObject> MaterialList,TArray<int> MaterialIndex,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) {}
	public UObject CopyMeshFromSkeletalMesh(UObject FromSkeletalMeshAsset,UObject ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
	public UObject CopyMeshToSkeletalMesh(UObject FromDynamicMesh,UObject ToSkeletalMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UObject Debug/*=nullptr*/) { return default; }
}
