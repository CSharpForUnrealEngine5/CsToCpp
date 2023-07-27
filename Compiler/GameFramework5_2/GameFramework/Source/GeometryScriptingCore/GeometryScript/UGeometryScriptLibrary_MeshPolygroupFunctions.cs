#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshPolygroupFunctions.h")]
public partial class UGeometryScriptLibrary_MeshPolygroupFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshPolygroupFunctions
	public static UDynamicMesh EnablePolygroups(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh SetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh,int NumLayers,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ClearPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh CopyPolygroupsLayer(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer FromGroupLayer,FGeometryScriptGroupLayer ToGroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ConvertUVIslandsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int UVLayer/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ConvertComponentsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputePolygroupsFromAngleThreshold(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,float CreaseAngle/*=15f*/,int MinGroupSize/*=2*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputePolygroupsFromPolygonDetection(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,bool bRespectUVSeams/*=true*/,bool bRespectHardNormals/*=false*/,double QuadAdjacencyWeight/*=1.0*/,double QuadMetricClamp/*=1.0*/,int MaxSearchRounds/*=1*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static int GetTrianglePolygroupID(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int TriangleID,bool bIsValidTriangle) { return default; }
	public static UDynamicMesh DeleteTrianglesInPolygroup(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int NumDeleted,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh GetAllTrianglePolygroupIDs(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	public static UDynamicMesh GetPolygroupIDsInMesh(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	public static UDynamicMesh GetTrianglesInPolygroup(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,FGeometryScriptIndexList TriangleIDsOut) { return default; }
	public static UDynamicMesh SetPolygroupForMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptMeshSelection Selection,int SetPolygroupIDOut,int SetPolygroupID/*=0*/,bool bGenerateNewPolygroup/*=false*/,bool bDeferChangeNotifications/*=false*/) { return default; }
}
