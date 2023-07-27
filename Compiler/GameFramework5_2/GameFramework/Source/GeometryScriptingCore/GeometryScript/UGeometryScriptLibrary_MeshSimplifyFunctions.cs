#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSimplifyFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSimplifyFunctions
	public static UDynamicMesh ApplySimplifyToPlanar(UDynamicMesh TargetMesh,FGeometryScriptPlanarSimplifyOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplySimplifyToPolygroupTopology(UDynamicMesh TargetMesh,FGeometryScriptPolygroupSimplifyOptions Options,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplySimplifyToTriangleCount(UDynamicMesh TargetMesh,int TriangleCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplySimplifyToVertexCount(UDynamicMesh TargetMesh,int VertexCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplySimplifyToTolerance(UDynamicMesh TargetMesh,float Tolerance,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
