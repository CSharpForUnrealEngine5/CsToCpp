namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBooleanFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBooleanFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Applies a Boolean operation (such as, Union, Intersect, and Subtract) to the Target Dynamic Mesh based on a Tool Dynamic Mesh.</summary>
	public static UDynamicMesh ApplyMeshBoolean(UDynamicMesh TargetMesh,FTransform TargetTransform,UDynamicMesh ToolMesh,FTransform ToolTransform,EGeometryScriptBooleanOperation Operation,FGeometryScriptMeshBooleanOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Mesh-Boolean-Union an object with itself to repair self-intersections, remove floating geometry, etc.</summary>
	public static UDynamicMesh ApplyMeshSelfUnion(UDynamicMesh TargetMesh,FGeometryScriptMeshSelfUnionOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Applies a plane cut to a mesh, optionally filling any holes created.</summary>
	public static UDynamicMesh ApplyMeshPlaneCut(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneCutOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Slices a mesh into two halves, with optional hole filling.</summary>
	public static UDynamicMesh ApplyMeshPlaneSlice(UDynamicMesh TargetMesh,FTransform CutFrame,FGeometryScriptMeshPlaneSliceOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Mirrors a mesh across a plane, with optional cutting and welding of triangles.</summary>
	public static UDynamicMesh ApplyMeshMirror(UDynamicMesh TargetMesh,FTransform MirrorFrame,FGeometryScriptMeshMirrorOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
