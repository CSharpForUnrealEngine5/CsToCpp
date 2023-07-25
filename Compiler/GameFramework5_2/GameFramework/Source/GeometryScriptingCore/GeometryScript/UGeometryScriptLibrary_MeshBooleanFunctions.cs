#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBooleanFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBooleanFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBooleanFunctions
	public UObject ApplyMeshBoolean(UObject TargetMesh,FTransform TargetTransform,UObject ToolMesh,FTransform ToolTransform,EGeometryScriptBooleanOperation Operation,FGeometryScriptMeshBooleanOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshSelfUnion(UObject TargetMesh,FGeometryScriptMeshSelfUnionOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshPlaneCut(UObject TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneCutOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshPlaneSlice(UObject TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneSliceOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshMirror(UObject TargetMesh,FTransform MirrorFrame,FGeometryScriptMeshMirrorOptions Options,UObject Debug/*=nullptr*/) { return default; }
}
