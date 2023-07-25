#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ContainmentFunctions.h")]
public partial class UGeometryScriptLibrary_ContainmentFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_ContainmentFunctions
	public UObject ComputeMeshConvexHull(UObject TargetMesh,UObject CopyToMesh,UObject CopyToMeshOut,FGeometryScriptMeshSelection Selection,FGeometryScriptConvexHullOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeMeshSweptHull(UObject TargetMesh,UObject CopyToMesh,UObject CopyToMeshOut,FTransform ProjectionFrame,FGeometryScriptSweptHullOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeMeshConvexDecomposition(UObject TargetMesh,UObject CopyToMesh,UObject CopyToMeshOut,FGeometryScriptConvexDecompositionOptions Options,UObject Debug/*=nullptr*/) { return default; }
}
