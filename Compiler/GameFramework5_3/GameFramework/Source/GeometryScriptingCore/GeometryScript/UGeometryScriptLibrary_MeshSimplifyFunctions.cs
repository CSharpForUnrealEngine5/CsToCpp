namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSimplifyFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Simplifies planar areas of the mesh that have more triangles than necessary. Note that it does not change the 3D shape of the mesh.</summary>
	public static UDynamicMesh ApplySimplifyToPlanar(UDynamicMesh TargetMesh,FGeometryScriptPlanarSimplifyOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Simplifies the mesh down to the PolyGroup Topology. For example, the high-level faces of the mesh PolyGroups.</summary>
	public static UDynamicMesh ApplySimplifyToPolygroupTopology(UDynamicMesh TargetMesh,FGeometryScriptPolygroupSimplifyOptions Options,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Simplifies the mesh until a target triangle count is reached. Behavior can be additionally controlled with the Options.</summary>
	public static UDynamicMesh ApplySimplifyToTriangleCount(UDynamicMesh TargetMesh,int TriangleCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Simplifies the mesh until a target vertex count is reached. Behavior can be additionally controlled with the Options.</summary>
	public static UDynamicMesh ApplySimplifyToVertexCount(UDynamicMesh TargetMesh,int VertexCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Simplifies the mesh to a target geometric tolerance. Stops when any further simplification would result in a deviation from the input mesh larger than the tolerance.</summary>
	public static UDynamicMesh ApplySimplifyToTolerance(UDynamicMesh TargetMesh,float Tolerance,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
