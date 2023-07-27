#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshMaterialFunctions.h")]
public partial class UGeometryScriptLibrary_MeshMaterialFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshMaterialFunctions
	public static int GetMaxMaterialID(UDynamicMesh TargetMesh,bool bHasMaterialIDs) { return default; }
	public static UDynamicMesh EnableMaterialIDs(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ClearMaterialIDs(UDynamicMesh TargetMesh,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh RemapMaterialIDs(UDynamicMesh TargetMesh,int FromMaterialID,int ToMaterialID,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static int GetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,bool bIsValidTriangle) { return default; }
	public static UDynamicMesh GetMaterialIDsOfTriangles(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,FGeometryScriptIndexList MaterialIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList MaterialIDList,bool bHasMaterialIDs) { return default; }
	public static UDynamicMesh GetTrianglesByMaterialID(UDynamicMesh TargetMesh,int MaterialID,FGeometryScriptIndexList TriangleIDList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetTriangleMaterialID(UDynamicMesh TargetMesh,int TriangleID,int MaterialID,bool bIsValidTriangle,bool bDeferChangeNotifications/*=false*/) { return default; }
	public static UDynamicMesh SetAllTriangleMaterialIDs(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleMaterialIDList,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMaterialIDOnTriangles(UDynamicMesh TargetMesh,FGeometryScriptIndexList TriangleIDList,int MaterialID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetMaterialIDForMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptMeshSelection Selection,int MaterialID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetPolygroupMaterialID(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int MaterialID,bool bIsValidPolygroupID,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh DeleteTrianglesByMaterialID(UDynamicMesh TargetMesh,int MaterialID,int NumDeleted,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CompactMaterialIDs(UDynamicMesh TargetMesh,TArray<UMaterialInterface> SourceMaterialList,TArray<UMaterialInterface> CompactedMaterialList,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
