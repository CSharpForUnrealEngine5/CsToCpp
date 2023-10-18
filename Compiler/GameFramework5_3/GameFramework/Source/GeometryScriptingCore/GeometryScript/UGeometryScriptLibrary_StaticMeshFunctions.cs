namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Although the class name indicates StaticMeshFunctions, that was a naming mistake that is difficult</summary>
[CppInclude("GeometryScript/MeshAssetFunctions.h")]
public partial class UGeometryScriptLibrary_StaticMeshFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Extracts a Dynamic Mesh from a Static Mesh Asset.</summary>
	public static UDynamicMesh CopyMeshFromStaticMesh(UStaticMesh FromStaticMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Updates a Static Mesh Asset with new geometry converted from a Dynamic Mesh.</summary>
	public static UDynamicMesh CopyMeshToStaticMesh(UDynamicMesh FromDynamicMesh,UStaticMesh ToStaticMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Extracts the Material List and corresponding Material Indices from the specified LOD of the Static Mesh Asset.</summary>
	public static void GetSectionMaterialListFromStaticMesh(UStaticMesh FromStaticMeshAsset,FGeometryScriptMeshReadLOD RequestedLOD,TArray<UMaterialInterface> MaterialList,TArray<int> MaterialIndex,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>Extracts a Dynamic Mesh from a Skeletal Mesh Asset.</summary>
	public static UDynamicMesh CopyMeshFromSkeletalMesh(USkeletalMesh FromSkeletalMeshAsset,UDynamicMesh ToDynamicMesh,FGeometryScriptCopyMeshFromAssetOptions AssetOptions,FGeometryScriptMeshReadLOD RequestedLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Updates a Skeletal Mesh Asset with new geometry and bone weights data from a Dynamic Mesh.</summary>
	public static UDynamicMesh CopyMeshToSkeletalMesh(UDynamicMesh FromDynamicMesh,USkeletalMesh ToSkeletalMeshAsset,FGeometryScriptCopyMeshToAssetOptions Options,FGeometryScriptMeshWriteLOD TargetLOD,EGeometryScriptOutcomePins Outcome,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
