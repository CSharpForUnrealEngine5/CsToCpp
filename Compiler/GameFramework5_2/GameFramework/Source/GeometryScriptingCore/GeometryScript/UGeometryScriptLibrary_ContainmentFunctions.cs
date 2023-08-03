#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ContainmentFunctions.h")]
public partial class UGeometryScriptLibrary_ContainmentFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Compute the Convex Hull of a given Mesh, or part of the mesh if an optional Selection is provided</summary>
	public static UDynamicMesh ComputeMeshConvexHull(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FGeometryScriptMeshSelection Selection,FGeometryScriptConvexHullOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute the Swept Hull of a given Mesh for a given 3D Plane defined by ProjectionFrame.</summary>
	public static UDynamicMesh ComputeMeshSweptHull(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FTransform ProjectionFrame,FGeometryScriptSweptHullOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute a Convex Hull Decomposition of the given TargetMesh. Assuming more than one hull is requested,</summary>
	public static UDynamicMesh ComputeMeshConvexDecomposition(UDynamicMesh TargetMesh,UDynamicMesh CopyToMesh,UDynamicMesh CopyToMeshOut,FGeometryScriptConvexDecompositionOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
