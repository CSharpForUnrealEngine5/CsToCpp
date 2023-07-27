#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ContainmentFunctions.h")]
public partial class UGeometryScriptLibrary_ContainmentFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_ContainmentFunctions
	public static UDynamicMesh ComputeMeshConvexHull(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FGeometryScriptMeshSelection Selection,FGeometryScriptConvexHullOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeMeshSweptHull(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FTransform ProjectionFrame,FGeometryScriptSweptHullOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeMeshConvexDecomposition(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FGeometryScriptConvexDecompositionOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
