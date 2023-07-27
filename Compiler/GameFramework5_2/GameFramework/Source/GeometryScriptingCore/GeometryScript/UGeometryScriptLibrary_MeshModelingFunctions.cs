#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshModelingFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshModelingFunctions
	public static UDynamicMesh ApplyMeshDisconnectFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,bool bAllowBowtiesInOutput/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshDuplicateFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewTriangles,FGeometryScriptMeshEditPolygroupOptions GroupOptions/*=new FGeometryScriptMeshEditPolygroupOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshOffset(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshShell(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshLinearExtrudeFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshLinearExtrudeOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshOffsetFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshInsetOutsetFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshInsetOutsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshBevelSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshBevelSelectionMode BevelMode,FGeometryScriptMeshBevelSelectionOptions BevelOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshPolygroupBevel(UDynamicMesh TargetMesh,FGeometryScriptMeshBevelOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ApplyMeshExtrude_Compatibility_5p0(UDynamicMesh TargetMesh,FGeometryScriptMeshExtrudeOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
