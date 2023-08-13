namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshModelingFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Disconnect the triangles of TargetMesh identified by the Selection.</summary>
	public static UDynamicMesh ApplyMeshDisconnectFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,bool bAllowBowtiesInOutput/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Duplicate the triangles of TargetMesh identified by the Selection</summary>
	public static UDynamicMesh ApplyMeshDuplicateFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptMeshSelection NewTriangles,FGeometryScriptMeshEditPolygroupOptions GroupOptions/*=new FGeometryScriptMeshEditPolygroupOptions()*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Offset the vertices of TargetMesh from their initial positions based on averaged vertex normals.</summary>
	public static UDynamicMesh ApplyMeshOffset(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create a thickened shell from TargetMesh by offsetting the vertex positions along averaged vertex normals, inwards or outwards.</summary>
	public static UDynamicMesh ApplyMeshShell(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply Linear Extrusion (ie extrusion in a single direction) to the triangles of TargetMesh identified by the Selection.</summary>
	public static UDynamicMesh ApplyMeshLinearExtrudeFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshLinearExtrudeOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply an Offset to the faces of TargetMesh identified by the Selection, or all faces if the Selection is empty.</summary>
	public static UDynamicMesh ApplyMeshOffsetFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshOffsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply an Inset or Outset to the faces of TargetMesh identified by the Selection, or all faces if the Selection is empty.</summary>
	public static UDynamicMesh ApplyMeshInsetOutsetFaces(UDynamicMesh TargetMesh,FGeometryScriptMeshInsetOutsetFacesOptions Options,FGeometryScriptMeshSelection Selection,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Apply a Mesh Bevel operation to parts of TargetMesh using the BevelOptions settings.</summary>
	public static UDynamicMesh ApplyMeshBevelSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,EGeometryScriptMeshBevelSelectionMode BevelMode,FGeometryScriptMeshBevelSelectionOptions BevelOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ApplyMeshPolygroupBevel</summary>
	public static UDynamicMesh ApplyMeshPolygroupBevel(UDynamicMesh TargetMesh,FGeometryScriptMeshBevelOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Backwards-Compatibility implementations</summary>
	public static UDynamicMesh ApplyMeshExtrude_Compatibility_5p0(UDynamicMesh TargetMesh,FGeometryScriptMeshExtrudeOptions Options,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
