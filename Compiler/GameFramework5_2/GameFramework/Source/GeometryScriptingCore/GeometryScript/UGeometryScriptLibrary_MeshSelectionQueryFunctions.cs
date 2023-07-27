#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionQueryFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSelectionQueryFunctions
	public static UDynamicMesh GetMeshSelectionBoundingBox(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FBox SelectionBounds,bool bIsEmpty,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetMeshSelectionBoundaryLoops(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,TArray<FGeometryScriptIndexList> IndexLoops,TArray<FGeometryScriptPolyPath> PathLoops,int NumLoops,bool bFoundErrors,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
