#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionQueryFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSelectionQueryFunctions
	public UObject GetMeshSelectionBoundingBox(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FBox SelectionBounds,bool bIsEmpty,UObject Debug/*=nullptr*/) { return default; }
	public UObject GetMeshSelectionBoundaryLoops(UObject TargetMesh,FGeometryScriptMeshSelection Selection,TArray<FGeometryScriptIndexList> IndexLoops,TArray<FGeometryScriptPolyPath> PathLoops,int NumLoops,bool bFoundErrors,UObject Debug/*=nullptr*/) { return default; }
}
