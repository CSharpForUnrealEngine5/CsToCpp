namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSubdivideFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSubdivideFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ApplyPNTessellation</summary>
	public static UDynamicMesh ApplyPNTessellation(UDynamicMesh TargetMesh,FGeometryScriptPNTessellateOptions Options,int TessellationLevel/*=3*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyUniformTessellation</summary>
	public static UDynamicMesh ApplyUniformTessellation(UDynamicMesh TargetMesh,int TessellationLevel/*=3*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplySelectiveTessellation</summary>
	public static UDynamicMesh ApplySelectiveTessellation(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptSelectiveTessellateOptions Options,int TessellationLevel/*=1*/,ESelectiveTessellatePatternType PatternType/*=ESelectiveTessellatePatternType.ConcentricRings*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
