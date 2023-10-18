namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVoxelFunctions.h")]
public partial class UGeometryScriptLibrary_MeshVoxelFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Replaces the mesh with a voxelized-and-meshed approximation (VoxWrap operation).</summary>
	public static UDynamicMesh ApplyMeshSolidify(UDynamicMesh TargetMesh,FGeometryScriptSolidifyOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Replaces the mesh with an SDF-based offset mesh approximation.</summary>
	public static UDynamicMesh ApplyMeshMorphology(UDynamicMesh TargetMesh,FGeometryScriptMorphologyOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
