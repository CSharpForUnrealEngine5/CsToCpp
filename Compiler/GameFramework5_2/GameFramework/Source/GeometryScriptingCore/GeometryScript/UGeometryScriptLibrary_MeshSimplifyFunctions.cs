#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSimplifyFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSimplifyFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSimplifyFunctions
	public UObject ApplySimplifyToPlanar(UObject TargetMesh,FGeometryScriptPlanarSimplifyOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplySimplifyToPolygroupTopology(UObject TargetMesh,FGeometryScriptPolygroupSimplifyOptions Options,FGeometryScriptGroupLayer GroupLayer,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplySimplifyToTriangleCount(UObject TargetMesh,int TriangleCount,FGeometryScriptSimplifyMeshOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplySimplifyToVertexCount(UObject TargetMesh,int VertexCount,FGeometryScriptSimplifyMeshOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplySimplifyToTolerance(UObject TargetMesh,float Tolerance,FGeometryScriptSimplifyMeshOptions Options,UObject Debug/*=nullptr*/) { return default; }
}
