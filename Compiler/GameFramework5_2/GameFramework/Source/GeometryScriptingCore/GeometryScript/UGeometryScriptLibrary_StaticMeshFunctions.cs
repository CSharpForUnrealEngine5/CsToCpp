#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Although the class name indicates StaticMeshFunctions, that was a naming mistake that is difficult</summary>
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
public partial class UGeometryScriptLibrary_StaticMeshFunctions : UBlueprintFunctionLibrary {
	///<summary>CopyMeshFromStaticMesh</summary>
	public static UDynamicMesh CopyMeshFromStaticMesh(UStaticMesh FromStaticMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CopyMeshToStaticMesh</summary>
	public static UDynamicMesh CopyMeshToStaticMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>GetSectionMaterialListFromStaticMesh</summary>
	public static void GetSectionMaterialListFromStaticMesh(UStaticMesh FromStaticMeshAsset,FGeometryScriptMeshReadLOD RequestedLOD,TArray<UMaterialInterface> MaterialList,TArray<int> MaterialIndex,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>CopyMeshFromSkeletalMesh</summary>
	public static UDynamicMesh CopyMeshFromSkeletalMesh(USkeletalMesh FromSkeletalMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CopyMeshToSkeletalMesh</summary>
	public static UDynamicMesh CopyMeshToSkeletalMesh(UDynamicMesh FromDynamicMesh,USkeletalMesh ToSkeletalMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
