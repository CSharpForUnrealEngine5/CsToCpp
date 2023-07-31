#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSimplifyFunctions : UBlueprintFunctionLibrary {
	///<summary>ApplySimplifyToPlanar</summary>
	public static UDynamicMesh ApplySimplifyToPlanar(UDynamicMesh TargetMesh,FGeometryScriptPlanarSimplifyOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplySimplifyToPolygroupTopology</summary>
	public static UDynamicMesh ApplySimplifyToPolygroupTopology(UDynamicMesh TargetMesh,FGeometryScriptPolygroupSimplifyOptions Options,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplySimplifyToTriangleCount</summary>
	public static UDynamicMesh ApplySimplifyToTriangleCount(UDynamicMesh TargetMesh,int TriangleCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplySimplifyToVertexCount</summary>
	public static UDynamicMesh ApplySimplifyToVertexCount(UDynamicMesh TargetMesh,int VertexCount,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplySimplifyToTolerance</summary>
	public static UDynamicMesh ApplySimplifyToTolerance(UDynamicMesh TargetMesh,float Tolerance,FGeometryScriptSimplifyMeshOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
