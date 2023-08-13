namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBooleanFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBooleanFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ApplyMeshBoolean</summary>
	public static UDynamicMesh ApplyMeshBoolean(UDynamicMesh TargetMesh,FTransform TargetTransform,UDynamicMesh ToolMesh,FTransform ToolTransform,EGeometryScriptBooleanOperation Operation,FGeometryScriptMeshBooleanOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMeshSelfUnion</summary>
	public static UDynamicMesh ApplyMeshSelfUnion(UDynamicMesh TargetMesh,FGeometryScriptMeshSelfUnionOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMeshPlaneCut</summary>
	public static UDynamicMesh ApplyMeshPlaneCut(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneCutOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMeshPlaneSlice</summary>
	public static UDynamicMesh ApplyMeshPlaneSlice(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneSliceOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMeshMirror</summary>
	public static UDynamicMesh ApplyMeshMirror(UDynamicMesh TargetMesh,FTransform MirrorFrame,FGeometryScriptMeshMirrorOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
