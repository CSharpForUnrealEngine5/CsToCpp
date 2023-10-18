namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionQueryFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSelectionQueryFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the 3D Bounding Box of a Mesh Selection, ie bounding box of vertices contained in the Selection</summary>
	public static UDynamicMesh GetMeshSelectionBoundingBox(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,FBox SelectionBounds,bool bIsEmpty,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute the set of Vertex Loops bordering a Mesh Selection. Both the 3D polylines and lists of vertex indices are returned for each Loop.</summary>
	public static UDynamicMesh GetMeshSelectionBoundaryLoops(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,TArray<FGeometryScriptIndexList> IndexLoops,TArray<FGeometryScriptPolyPath> PathLoops,int NumLoops,bool bFoundErrors,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
