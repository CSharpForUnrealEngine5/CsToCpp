namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshPolygroupFunctions.h")]
public partial class UGeometryScriptLibrary_MeshPolygroupFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Enables the standard PolyGroup Layer on the Target Mesh.</summary>
	public static UDynamicMesh EnablePolygroups(UDynamicMesh TargetMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sets the number of extended PolyGroup Layers on a Mesh.</summary>
	public static UDynamicMesh SetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh,int NumLayers,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Resets the triangle PolyGroup assignments within a PolyGroup Layer to the given Clear Value (or 0 if no Clear Value is specified).</summary>
	public static UDynamicMesh ClearPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int ClearValue/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Copies the triangle PolyGroup assignments from one layer on the Target Mesh to another.</summary>
	public static UDynamicMesh CopyPolygroupsLayer(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer FromGroupLayer,FGeometryScriptGroupLayer ToGroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Creates and assigns a new PolyGroup for each disconnected UV island of a Mesh.</summary>
	public static UDynamicMesh ConvertUVIslandsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int UVLayer/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Creates and assigns a new PolyGroup for each disconnected component of a Mesh. Regions of a mesh are disconnected they do not have a triangle in common.</summary>
	public static UDynamicMesh ConvertComponentsToPolygroups(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sets PolyGroups by partitioning the mesh based on an edge crease/opening-angle.</summary>
	public static UDynamicMesh ComputePolygroupsFromAngleThreshold(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,float CreaseAngle/*=15f*/,int MinGroupSize/*=2*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sets PolyGroups by identifying adjacent triangles that form reasonable quads. Note any triangles that do not neatly pair to form quads will receive their own PolyGroup.</summary>
	public static UDynamicMesh ComputePolygroupsFromPolygonDetection(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,bool bRespectUVSeams/*=true*/,bool bRespectHardNormals/*=false*/,double QuadAdjacencyWeight/*=1.0*/,double QuadMetricClamp/*=1.0*/,int MaxSearchRounds/*=1*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Gets the PolyGroup ID associated with the specified Triangle ID and stored in the Group Layer.</summary>
	public static int GetTrianglePolygroupID(UDynamicMesh TargetMesh,FGeometryScriptGroupLayer GroupLayer,int TriangleID,bool bIsValidTriangle) { return default; }
	///<summary>Deletes all triangles from the Target Mesh that have a particular PolyGroup ID, in the specific Group Layer.</summary>
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
