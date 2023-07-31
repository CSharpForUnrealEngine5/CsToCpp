#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshPolygroupFunctions.h")]
public partial class UGeometryScriptLibrary_MeshPolygroupFunctions : UBlueprintFunctionLibrary {
	///<summary>EnablePolygroups</summary>
	public static UDynamicMesh EnablePolygroups(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>SetNumExtendedPolygroupLayers</summary>
	public static UDynamicMesh SetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh,int NumLayers,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ClearPolygroups</summary>
	public static UDynamicMesh ClearPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>CopyPolygroupsLayer</summary>
	public static UDynamicMesh CopyPolygroupsLayer(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer FromGroupLayer,FGeometryScriptGroupLayer ToGroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ConvertUVIslandsToPolygroups</summary>
	public static UDynamicMesh ConvertUVIslandsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int UVLayer/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ConvertComponentsToPolygroups</summary>
	public static UDynamicMesh ConvertComponentsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ComputePolygroupsFromAngleThreshold</summary>
	public static UDynamicMesh ComputePolygroupsFromAngleThreshold(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,float CreaseAngle/*=15f*/,int MinGroupSize/*=2*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>ComputePolygroupsFromPolygonDetection</summary>
	public static UDynamicMesh ComputePolygroupsFromPolygonDetection(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,bool bRespectUVSeams/*=true*/,bool bRespectHardNormals/*=false*/,double QuadAdjacencyWeight/*=1.0*/,double QuadMetricClamp/*=1.0*/,int MaxSearchRounds/*=1*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>GetTrianglePolygroupID</summary>
	public static int GetTrianglePolygroupID(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>DeleteTrianglesInPolygroup</summary>
	public static UDynamicMesh DeleteTrianglesInPolygroup(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,int NumDeleted,bool bDeferChangeNotifications/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Create list of per-triangle PolyGroup IDs for the PolyGroup in the Mesh</summary>
	public static UDynamicMesh GetAllTrianglePolygroupIDs(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	///<summary>Create list of all unique PolyGroup IDs that exist in the PolyGroup Layer in the Mesh</summary>
	public static UDynamicMesh GetPolygroupIDsInMesh(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptIndexList PolygroupIDsOut) { return default; }
	///<summary>Create list of all triangles with the given PolyGroup ID in the given GroupLayer (not necessarily a single connected-component)</summary>
	public static UDynamicMesh GetTrianglesInPolygroup(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int PolygroupID,FGeometryScriptIndexList TriangleIDsOut) { return default; }
	///<summary>Set a new PolyGroup on all the triangles of the given Selection, for the given GroupLayer.</summary>
	public static UDynamicMesh SetPolygroupForMeshSelection(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,FGeometryScriptMeshSelection Selection,int SetPolygroupIDOut,int SetPolygroupID/*=0*/,bool bGenerateNewPolygroup/*=false*/,bool bDeferChangeNotifications/*=false*/) { return default; }
}
