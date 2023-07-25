#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshModelingFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshModelingFunctions
	public UObject ApplyMeshDisconnectFaces(UObject TargetMesh,FGeometryScriptMeshSelection Selection,bool bAllowBowtiesInOutput/*=true*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshDuplicateFaces(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewTriangles,FGeometryScriptMeshEditPolygroupOptions GroupOptions/*=new FGeometryScriptMeshEditPolygroupOptions()*/,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshOffset(UObject TargetMesh,FGeometryScriptMeshOffsetOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshShell(UObject TargetMesh,FGeometryScriptMeshOffsetOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshLinearExtrudeFaces(UObject TargetMesh,FGeometryScriptMeshLinearExtrudeOptions Options,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshOffsetFaces(UObject TargetMesh,FGeometryScriptMeshOffsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshInsetOutsetFaces(UObject TargetMesh,FGeometryScriptMeshInsetOutsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshBevelSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshBevelSelectionMode BevelMode,FGeometryScriptMeshBevelSelectionOptions BevelOptions,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshPolygroupBevel(UObject TargetMesh,FGeometryScriptMeshBevelOptions Options,UObject Debug/*=nullptr*/) { return default; }
	public UObject ApplyMeshExtrude_Compatibility_5p0(UObject TargetMesh,FGeometryScriptMeshExtrudeOptions Options,UObject Debug/*=nullptr*/) { return default; }
}
