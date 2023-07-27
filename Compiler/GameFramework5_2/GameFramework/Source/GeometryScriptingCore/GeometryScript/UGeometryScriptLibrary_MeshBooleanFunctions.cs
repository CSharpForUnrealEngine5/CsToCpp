#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBooleanFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBooleanFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBooleanFunctions
	public static UDynamicMesh ApplyMeshBoolean(UDynamicMesh TargetMesh,FTransform TargetTransform,UDynamicMesh ToolMesh,FTransform ToolTransform,EGeometryScriptBooleanOperation Operation,FGeometryScriptMeshBooleanOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshSelfUnion(UDynamicMesh TargetMesh,FGeometryScriptMeshSelfUnionOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshPlaneCut(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneCutOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshPlaneSlice(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneSliceOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshMirror(UDynamicMesh TargetMesh,FTransform MirrorFrame,FGeometryScriptMeshMirrorOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
