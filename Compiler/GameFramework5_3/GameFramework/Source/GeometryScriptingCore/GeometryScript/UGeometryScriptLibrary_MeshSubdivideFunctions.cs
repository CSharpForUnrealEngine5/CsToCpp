namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSubdivideFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSubdivideFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Apply PN Tessellation to the Target Mesh as controlled by the Tessellation Level and the Options.</summary>
	public static UDynamicMesh ApplyPNTessellation(UDynamicMesh TargetMesh,FGeometryScriptPNTessellateOptions Options,int TessellationLevel/*=3*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply Uniform Tessellation to the Target Mesh as controlled by the Tessellation Level and the Options.</summary>
	public static UDynamicMesh ApplyUniformTessellation(UDynamicMesh TargetMesh,int TessellationLevel/*=3*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Selectively Tessellate a Selection of the Target Mesh or possibly the entire mesh as controlled by</summary>
	public static UDynamicMesh ApplySelectiveTessellation(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptSelectiveTessellateOptions Options,int TessellationLevel/*=1*/,ESelectiveTessellatePatternType PatternType/*=ESelectiveTessellatePatternType.ConcentricRings*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
