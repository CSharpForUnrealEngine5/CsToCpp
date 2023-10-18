namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshMaterialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshMaterialFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetMaxMaterialID</summary>
	public static int GetMaxMaterialID(UDynamicMesh TargetMesh,bool bHasMaterialIDs) { return default; }
	///<summary>Enables per-triangle Material IDs on a mesh and initializes the values to 0.</summary>
	public static UDynamicMesh EnableMaterialIDs(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Resets all Material IDs on a mesh to the given ClearValue, or 0 if no ClearValue is provided.</summary>
	public static UDynamicMesh ClearMaterialIDs(UDynamicMesh TargetMesh,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>For all triangles with a Material ID matching the given value (From Material ID), update the Material ID to the new value (To Material ID).</summary>
	public static UDynamicMesh RemapMaterialIDs(UDynamicMesh TargetMesh,int FromMaterialID,int ToMaterialID,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Returns the current Material ID for a Triangle.</summary>
	public static int GetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>This populates the MaterialIDList with Material IDs for each triangle in the TriangleIDList.</summary>
	public static UDynamicMesh GetMaterialIDsOfTriangles(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,FGeometryScriptIndexList MaterialIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Returns an Index List of all triangle Material IDs, constructed with one entry for each consecutive Triangle ID.</summary>
	public static UDynamicMesh GetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList MaterialIDList,bool bHasMaterialIDs) { return default; }
	///<summary>Populates Triangle ID List with the Triangle IDs of triangles that share the specified Material ID in the Target Mesh.</summary>
	public static UDynamicMesh GetTrianglesByMaterialID(UDynamicMesh TargetMesh,int MaterialID,FGeometryScriptIndexList TriangleIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Assigns the specified triangle the given Material ID.</summary>
	public static UDynamicMesh SetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,int MaterialID,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	///<summary>Sets the Material ID of all triangles in a mesh to the values in an input Index List.</summary>
	public static UDynamicMesh SetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleMaterialIDList,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Assigns the Material ID to all the triangles specified by the Triangle ID List.</summary>
	public static UDynamicMesh SetMaterialIDOnTriangles(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,int MaterialID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set a new MaterialID on all the triangles of the given Selection.</summary>
	public static UDynamicMesh SetMaterialIDForMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,int MaterialID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Set a new MaterialID on all the triangles of TargetMesh with the given PolyGroup.</summary>
	public static UDynamicMesh SetPolygroupMaterialID(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int MaterialID,bool bIsValidPolygroupID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Delete all triangles in TargetMesh with the given MaterialID</summary>
	public static UDynamicMesh DeleteTrianglesByMaterialID(UDynamicMesh TargetMesh,int MaterialID,int NumDeleted,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compact the MaterialIDs of the TargetMesh, ie remove any un-used MaterialIDs and remap the remaining</summary>
	public static UDynamicMesh CompactMaterialIDs(UDynamicMesh TargetMesh,TArray<UMaterialInterface> SourceMaterialList,TArray<UMaterialInterface> CompactedMaterialList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
