#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSubdivideFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSubdivideFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSubdivideFunctions
	public UObject ApplyPNTessellation(UObject TargetMesh,FGeometryScriptPNTessellateOptions Options,int TessellationLevel/*=3*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyUniformTessellation(UObject TargetMesh,int TessellationLevel/*=3*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplySelectiveTessellation(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptSelectiveTessellateOptions Options,int TessellationLevel/*=1*/,ESelectiveTessellatePatternType PatternType/*=ESelectiveTessellatePatternType.ConcentricRings*/,UObject Debug/*=nullptr*/) { return default; }
}
