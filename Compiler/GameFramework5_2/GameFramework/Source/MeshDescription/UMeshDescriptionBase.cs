#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshDescriptionBase.h")]
public partial class UMeshDescriptionBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Empty the mesh description</summary>
	public  void Empty() {}
	///<summary>Return whether the mesh description is empty</summary>
	public  bool IsEmpty() { return default; }
	///<summary>Reserves space for this number of new vertices</summary>
	public  void ReserveNewVertices(int NumberOfNewVertices) {}
	///<summary>Adds a new vertex to the mesh and returns its ID</summary>
	public  FVertexID CreateVertex() { return default; }
	///<summary>Adds a new vertex to the mesh with the given ID</summary>
	public  void CreateVertexWithID(FVertexID VertexID) {}
	///<summary>Deletes a vertex from the mesh</summary>
	public  void DeleteVertex(FVertexID VertexID) {}
	///<summary>Returns whether the passed vertex ID is valid</summary>
	public  bool IsVertexValid(FVertexID VertexID) { return default; }
	///<summary>Returns the number of vertices</summary>
	public  int GetVertexCount() { return default; }
	///<summary>Reserves space for this number of new vertex instances</summary>
	public  void ReserveNewVertexInstances(int NumberOfNewVertexInstances) {}
	///<summary>Adds a new vertex instance to the mesh and returns its ID</summary>
	public  FVertexInstanceID CreateVertexInstance(FVertexID VertexID) { return default; }
	///<summary>Adds a new vertex instance to the mesh with the given ID</summary>
	public  void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID,FVertexID VertexID) {}
	///<summary>Deletes a vertex instance from a mesh</summary>
	public  void DeleteVertexInstance(FVertexInstanceID VertexInstanceID,TArray<FVertexID> OrphanedVertices) {}
	///<summary>Returns whether the passed vertex instance ID is valid</summary>
	public  bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID) { return default; }
	///<summary>Returns the number of vertex instances</summary>
	public  int GetVertexInstanceCount() { return default; }
	///<summary>Reserves space for this number of new edges</summary>
	public  void ReserveNewEdges(int NumberOfNewEdges) {}
	///<summary>Adds a new edge to the mesh and returns its ID</summary>
	public  FEdgeID CreateEdge(FVertexID VertexID0,FVertexID VertexID1) { return default; }
	///<summary>Adds a new edge to the mesh with the given ID</summary>
	public  void CreateEdgeWithID(FEdgeID EdgeID,FVertexID VertexID0,FVertexID VertexID1) {}
	///<summary>Deletes an edge from a mesh</summary>
	public  void DeleteEdge(FEdgeID EdgeID,TArray<FVertexID> OrphanedVertices) {}
	///<summary>Returns whether the passed edge ID is valid</summary>
	public  bool IsEdgeValid(FEdgeID EdgeID) { return default; }
	///<summary>Returns the number of edges</summary>
	public  int GetEdgeCount() { return default; }
	///<summary>Reserves space for this number of new triangles</summary>
	public  void ReserveNewTriangles(int NumberOfNewTriangles) {}
	///<summary>Adds a new triangle to the mesh and returns its ID. This will also make an encapsulating polygon, and any missing edges.</summary>
	public  FTriangleID CreateTriangle(FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) { return default; }
	///<summary>Adds a new triangle to the mesh with the given ID. This will also make an encapsulating polygon, and any missing edges.</summary>
	public  void CreateTriangleWithID(FTriangleID TriangleID,FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) {}
	///<summary>Deletes a triangle from the mesh</summary>
	public  void DeleteTriangle(FTriangleID TriangleID,TArray<FEdgeID> OrphanedEdges,TArray<FVertexInstanceID> OrphanedVertexInstances,TArray<FPolygonGroupID> OrphanedPolygonGroupsPtr) {}
	///<summary>Returns whether the passed triangle ID is valid</summary>
	public  bool IsTriangleValid(FTriangleID TriangleID) { return default; }
	///<summary>Returns the number of triangles</summary>
	public  int GetTriangleCount() { return default; }
	///<summary>Reserves space for this number of new polygons</summary>
	public  void ReserveNewPolygons(int NumberOfNewPolygons) {}
	///<summary>Adds a new polygon to the mesh and returns its ID. This will also make any missing edges, and all constituent triangles.</summary>
	public  FPolygonID CreatePolygon(FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) { return default; }
	///<summary>Adds a new polygon to the mesh with the given ID. This will also make any missing edges, and all constituent triangles.</summary>
	public  void CreatePolygonWithID(FPolygonID PolygonID,FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) {}
	///<summary>Deletes a polygon from the mesh</summary>
	public  void DeletePolygon(FPolygonID PolygonID,TArray<FEdgeID> OrphanedEdges,TArray<FVertexInstanceID> OrphanedVertexInstances,TArray<FPolygonGroupID> OrphanedPolygonGroups) {}
	///<summary>Returns whether the passed polygon ID is valid</summary>
	public  bool IsPolygonValid(FPolygonID PolygonID) { return default; }
	///<summary>Returns the number of polygons</summary>
	public  int GetPolygonCount() { return default; }
	///<summary>Reserves space for this number of new polygon groups</summary>
	public  void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups) {}
	///<summary>Adds a new polygon group to the mesh and returns its ID</summary>
	public  FPolygonGroupID CreatePolygonGroup() { return default; }
	///<summary>Adds a new polygon group to the mesh with the given ID</summary>
	public  void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID) {}
	///<summary>Deletes a polygon group from the mesh</summary>
	public  void DeletePolygonGroup(FPolygonGroupID PolygonGroupID) {}
	///<summary>Returns whether the passed polygon group ID is valid</summary>
	public  bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID) { return default; }
	///<summary>Returns the number of polygon groups</summary>
	public  int GetPolygonGroupCount() { return default; }
	///<summary>Returns whether a given vertex is orphaned, i.e. it doesn&#39;t form part of any polygon</summary>
	public  bool IsVertexOrphaned(FVertexID VertexID) { return default; }
	///<summary>Returns the edge ID defined by the two given vertex IDs, if there is one; otherwise INDEX_NONE</summary>
	public  FEdgeID GetVertexPairEdge(FVertexID VertexID0,FVertexID VertexID1) { return default; }
	///<summary>Returns reference to an array of Edge IDs connected to this vertex</summary>
	public  void GetVertexConnectedEdges(FVertexID VertexID,TArray<FEdgeID> OutEdgeIDs) {}
	///<summary>Returns number of edges connected to this vertex</summary>
	public  int GetNumVertexConnectedEdges(FVertexID VertexID) { return default; }
	///<summary>Returns reference to an array of VertexInstance IDs instanced from this vertex</summary>
	public  void GetVertexVertexInstances(FVertexID VertexID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	///<summary>Returns number of vertex instances created from this vertex</summary>
	public  int GetNumVertexVertexInstances(FVertexID VertexID) { return default; }
	///<summary>Returns the triangles connected to this vertex</summary>
	public  void GetVertexConnectedTriangles(FVertexID VertexID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	///<summary>Returns number of triangles connected to this vertex</summary>
	public  int GetNumVertexConnectedTriangles(FVertexID VertexID) { return default; }
	///<summary>Returns the polygons connected to this vertex</summary>
	public  void GetVertexConnectedPolygons(FVertexID VertexID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	///<summary>Returns the number of polygons connected to this vertex</summary>
	public  int GetNumVertexConnectedPolygons(FVertexID VertexID) { return default; }
	///<summary>Returns the vertices adjacent to this vertex</summary>
	public  void GetVertexAdjacentVertices(FVertexID VertexID,TArray<FVertexID> OutAdjacentVertexIDs) {}
	///<summary>Gets a vertex position</summary>
	public  FVector GetVertexPosition(FVertexID VertexID) { return default; }
	///<summary>Sets a vertex position</summary>
	public  void SetVertexPosition(FVertexID VertexID,FVector Position) {}
	///<summary>Returns the vertex ID associated with the given vertex instance</summary>
	public  FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID) { return default; }
	///<summary>Returns the edge ID defined by the two given vertex instance IDs, if there is one; otherwise INDEX_NONE</summary>
	public  FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0,FVertexInstanceID VertexInstanceID1) { return default; }
	///<summary>Returns reference to an array of Triangle IDs connected to this vertex instance</summary>
	public  void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	///<summary>Returns the number of triangles connected to this vertex instance</summary>
	public  int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID) { return default; }
	///<summary>Returns the polygons connected to this vertex instance</summary>
	public  void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	///<summary>Returns the number of polygons connected to this vertex instance.</summary>
	public  int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID) { return default; }
	///<summary>Determine whether a given edge is an internal edge between triangles of a polygon</summary>
	public  bool IsEdgeInternal(FEdgeID EdgeID) { return default; }
	///<summary>Determine whether a given edge is an internal edge between triangles of a specific polygon</summary>
	public  bool IsEdgeInternalToPolygon(FEdgeID EdgeID,FPolygonID PolygonID) { return default; }
	///<summary>Returns reference to an array of triangle IDs connected to this edge</summary>
	public  void GetEdgeConnectedTriangles(FEdgeID EdgeID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	///<summary>Returns the number of triangles connected to this edge</summary>
	public  int GetNumEdgeConnectedTriangles(FEdgeID EdgeID) { return default; }
	///<summary>Returns the polygons connected to this edge</summary>
	public  void GetEdgeConnectedPolygons(FEdgeID EdgeID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	///<summary>Returns the number of polygons connected to this edge</summary>
	public  int GetNumEdgeConnectedPolygons(FEdgeID EdgeID) { return default; }
	///<summary>Returns the vertex ID corresponding to one of the edge endpoints</summary>
	public  FVertexID GetEdgeVertex(FEdgeID EdgeID,int VertexNumber) { return default; }
	///<summary>Returns a pair of vertex IDs defining the edge</summary>
	public  void GetEdgeVertices(FEdgeID EdgeID,TArray<FVertexID> OutVertexIDs) {}
	///<summary>Get the polygon which contains this triangle</summary>
	public  FPolygonID GetTrianglePolygon(FTriangleID TriangleID) { return default; }
	///<summary>Get the polygon group which contains this triangle</summary>
	public  FPolygonGroupID GetTrianglePolygonGroup(FTriangleID TriangleID) { return default; }
	///<summary>Determines if this triangle is part of an n-gon</summary>
	public  bool IsTrianglePartOfNgon(FTriangleID TriangleID) { return default; }
	///<summary>Get the vertex instances which define this triangle</summary>
	public  void GetTriangleVertexInstances(FTriangleID TriangleID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	///<summary>Get the specified vertex instance by index</summary>
	public  FVertexInstanceID GetTriangleVertexInstance(FTriangleID TriangleID,int Index) { return default; }
	///<summary>Returns the vertices which define this triangle</summary>
	public  void GetTriangleVertices(FTriangleID TriangleID,TArray<FVertexID> OutVertexIDs) {}
	///<summary>Returns the edges which define this triangle</summary>
	public  void GetTriangleEdges(FTriangleID TriangleID,TArray<FEdgeID> OutEdgeIDs) {}
	///<summary>Returns the adjacent triangles to this triangle</summary>
	public  void GetTriangleAdjacentTriangles(FTriangleID TriangleID,TArray<FTriangleID> OutTriangleIDs) {}
	///<summary>Return the vertex instance which corresponds to the given vertex on the given triangle, or INDEX_NONE</summary>
	public  FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID,FVertexID VertexID) { return default; }
	///<summary>Return reference to an array of triangle IDs which comprise this polygon</summary>
	public  void GetPolygonTriangles(FPolygonID PolygonID,TArray<FTriangleID> OutTriangleIDs) {}
	///<summary>Return the number of triangles which comprise this polygon</summary>
	public  int GetNumPolygonTriangles(FPolygonID PolygonID) { return default; }
	///<summary>Returns reference to an array of VertexInstance IDs forming the perimeter of this polygon</summary>
	public  void GetPolygonVertexInstances(FPolygonID PolygonID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	///<summary>Returns the number of vertices this polygon has</summary>
	public  int GetNumPolygonVertices(FPolygonID PolygonID) { return default; }
	///<summary>Returns the vertices which form the polygon perimeter</summary>
	public  void GetPolygonVertices(FPolygonID PolygonID,TArray<FVertexID> OutVertexIDs) {}
	///<summary>Returns the edges which form the polygon perimeter</summary>
	public  void GetPolygonPerimeterEdges(FPolygonID PolygonID,TArray<FEdgeID> OutEdgeIDs) {}
	///<summary>Populate the provided array with a list of edges which are internal to the polygon, i.e. those which separate</summary>
	public  void GetPolygonInternalEdges(FPolygonID PolygonID,TArray<FEdgeID> OutEdgeIDs) {}
	///<summary>Return the number of internal edges in this polygon</summary>
	public  int GetNumPolygonInternalEdges(FPolygonID PolygonID) { return default; }
	///<summary>Populates the passed array with adjacent polygons</summary>
	public  void GetPolygonAdjacentPolygons(FPolygonID PolygonID,TArray<FPolygonID> OutPolygonIDs) {}
	///<summary>Return the polygon group associated with a polygon</summary>
	public  FPolygonGroupID GetPolygonPolygonGroup(FPolygonID PolygonID) { return default; }
	///<summary>Return the vertex instance which corresponds to the given vertex on the given polygon, or INDEX_NONE</summary>
	public  FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID,FVertexID VertexID) { return default; }
	///<summary>Set the vertex instance at the given index around the polygon to the new value</summary>
	public  void SetPolygonVertexInstances(FPolygonID PolygonID,TArray<FVertexInstanceID> VertexInstanceIDs) {}
	///<summary>Sets the polygon group associated with a polygon</summary>
	public  void SetPolygonPolygonGroup(FPolygonID PolygonID,FPolygonGroupID PolygonGroupID) {}
	///<summary>Reverse the winding order of the vertices of this polygon</summary>
	public  void ReversePolygonFacing(FPolygonID PolygonID) {}
	///<summary>Generates triangles and internal edges for the given polygon</summary>
	public  void ComputePolygonTriangulation(FPolygonID PolygonID) {}
	///<summary>Returns the polygons associated with the given polygon group</summary>
	public  void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID,TArray<FPolygonID> OutPolygonIDs) {}
	///<summary>Returns the number of polygons in this polygon group</summary>
	public  int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID) { return default; }
}
