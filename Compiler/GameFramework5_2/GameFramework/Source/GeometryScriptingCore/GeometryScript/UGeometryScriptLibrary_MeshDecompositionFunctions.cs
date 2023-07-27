#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshDecompositionFunctions.h")]
public partial class UGeometryScriptLibrary_MeshDecompositionFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshDecompositionFunctions
	public static UDynamicMesh SplitMeshByComponents(UDynamicMesh TargetMesh,TArray<UDynamicMesh> ComponentMeshes,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SplitMeshByMaterialIDs(UDynamicMesh TargetMesh,TArray<UDynamicMesh> ComponentMeshes,TArray<int> ComponentMaterialIDs,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SplitMeshByPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,TArray<UDynamicMesh> ComponentMeshes,TArray<int> ComponentPolygroups,UDynamicMeshPool MeshPool,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetSubMeshFromMesh(UDynamicMesh TargetMesh,UDynamicMesh StoreToSubmesh,FGeometryScriptIndexList TriangleList,UDynamicMesh StoreToSubmeshOut,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshSelectionToMesh(UDynamicMesh TargetMesh,UDynamicMesh StoreToSubmesh,FGeometryScriptMeshSelection Selection,UDynamicMesh StoreToSubmeshOut,bool bAppendToExisting/*=false*/,bool bPreserveGroupIDs/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyMeshToMesh(UDynamicMesh CopyFromMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
