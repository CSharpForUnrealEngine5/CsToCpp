#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshMaterialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshMaterialFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetMaxMaterialID</summary>
	public static int GetMaxMaterialID(UDynamicMesh TargetMesh,bool bHasMaterialIDs) { return default; }
	///<summary>EnableMaterialIDs</summary>
	public static UDynamicMesh EnableMaterialIDs(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ClearMaterialIDs</summary>
	public static UDynamicMesh ClearMaterialIDs(UDynamicMesh TargetMesh,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>RemapMaterialIDs</summary>
	public static UDynamicMesh RemapMaterialIDs(UDynamicMesh TargetMesh,int FromMaterialID,int ToMaterialID,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>GetTriangleMaterialID</summary>
	public static int GetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>GetMaterialIDsOfTriangles</summary>
	public static UDynamicMesh GetMaterialIDsOfTriangles(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,FGeometryScriptIndexList MaterialIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>GetAllTriangleMaterialIDs</summary>
	public static UDynamicMesh GetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList MaterialIDList,bool bHasMaterialIDs) { return default; }
	///<summary>GetTrianglesByMaterialID</summary>
	public static UDynamicMesh GetTrianglesByMaterialID(UDynamicMesh TargetMesh,int MaterialID,FGeometryScriptIndexList TriangleIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>SetTriangleMaterialID</summary>
	public static UDynamicMesh SetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,int MaterialID,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	///<summary>SetAllTriangleMaterialIDs</summary>
	public static UDynamicMesh SetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleMaterialIDList,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>SetMaterialIDOnTriangles</summary>
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
