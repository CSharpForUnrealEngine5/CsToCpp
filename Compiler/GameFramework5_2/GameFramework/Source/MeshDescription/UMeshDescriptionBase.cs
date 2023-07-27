#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshDescriptionBase.h")]
public partial class UMeshDescriptionBase : UObject {
// MeshDescriptionBase
	public  void Empty() {}
	public  bool IsEmpty() { return default; }
	public  void ReserveNewVertices(int NumberOfNewVertices) {}
	public  FVertexID CreateVertex() { return default; }
	public  void CreateVertexWithID(FVertexID VertexID) {}
	public  void DeleteVertex(FVertexID VertexID) {}
	public  bool IsVertexValid(FVertexID VertexID) { return default; }
	public  int GetVertexCount() { return default; }
	public  void ReserveNewVertexInstances(int NumberOfNewVertexInstances) {}
	public  FVertexInstanceID CreateVertexInstance(FVertexID VertexID) { return default; }
	public  void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID,FVertexID VertexID) {}
	public  void DeleteVertexInstance(FVertexInstanceID VertexInstanceID,TArray<FVertexID> OrphanedVertices) {}
	public  bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID) { return default; }
	public  int GetVertexInstanceCount() { return default; }
	public  void ReserveNewEdges(int NumberOfNewEdges) {}
	public  FEdgeID CreateEdge(FVertexID VertexID0,FVertexID VertexID1) { return default; }
	public  void CreateEdgeWithID(FEdgeID EdgeID,FVertexID VertexID0,FVertexID VertexID1) {}
	public  void DeleteEdge(FEdgeID EdgeID,TArray<FVertexID> OrphanedVertices) {}
	public  bool IsEdgeValid(FEdgeID EdgeID) { return default; }
	public  int GetEdgeCount() { return default; }
	public  void ReserveNewTriangles(int NumberOfNewTriangles) {}
	public  FTriangleID CreateTriangle(FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) { return default; }
	public  void CreateTriangleWithID(FTriangleID TriangleID,FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) {}
	public  void DeleteTriangle(FTriangleID TriangleID,TArray<FEdgeID> OrphanedEdges,TArray<FVertexInstanceID> OrphanedVertexInstances,TArray<FPolygonGroupID> OrphanedPolygonGroupsPtr) {}
	public  bool IsTriangleValid(FTriangleID TriangleID) { return default; }
	public  int GetTriangleCount() { return default; }
	public  void ReserveNewPolygons(int NumberOfNewPolygons) {}
	public  FPolygonID CreatePolygon(FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) { return default; }
	public  void CreatePolygonWithID(FPolygonID PolygonID,FPolygonGroupID PolygonGroupID,TArray<FVertexInstanceID> VertexInstanceIDs,TArray<FEdgeID> NewEdgeIDs) {}
	public  void DeletePolygon(FPolygonID PolygonID,TArray<FEdgeID> OrphanedEdges,TArray<FVertexInstanceID> OrphanedVertexInstances,TArray<FPolygonGroupID> OrphanedPolygonGroups) {}
	public  bool IsPolygonValid(FPolygonID PolygonID) { return default; }
	public  int GetPolygonCount() { return default; }
	public  void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups) {}
	public  FPolygonGroupID CreatePolygonGroup() { return default; }
	public  void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID) {}
	public  void DeletePolygonGroup(FPolygonGroupID PolygonGroupID) {}
	public  bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID) { return default; }
	public  int GetPolygonGroupCount() { return default; }
	public  bool IsVertexOrphaned(FVertexID VertexID) { return default; }
	public  FEdgeID GetVertexPairEdge(FVertexID VertexID0,FVertexID VertexID1) { return default; }
	public  void GetVertexConnectedEdges(FVertexID VertexID,TArray<FEdgeID> OutEdgeIDs) {}
	public  int GetNumVertexConnectedEdges(FVertexID VertexID) { return default; }
	public  void GetVertexVertexInstances(FVertexID VertexID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	public  int GetNumVertexVertexInstances(FVertexID VertexID) { return default; }
	public  void GetVertexConnectedTriangles(FVertexID VertexID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	public  int GetNumVertexConnectedTriangles(FVertexID VertexID) { return default; }
	public  void GetVertexConnectedPolygons(FVertexID VertexID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	public  int GetNumVertexConnectedPolygons(FVertexID VertexID) { return default; }
	public  void GetVertexAdjacentVertices(FVertexID VertexID,TArray<FVertexID> OutAdjacentVertexIDs) {}
	public  FVector GetVertexPosition(FVertexID VertexID) { return default; }
	public  void SetVertexPosition(FVertexID VertexID,FVector Position) {}
	public  FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID) { return default; }
	public  FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0,FVertexInstanceID VertexInstanceID1) { return default; }
	public  void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	public  int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID) { return default; }
	public  void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	public  int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID) { return default; }
	public  bool IsEdgeInternal(FEdgeID EdgeID) { return default; }
	public  bool IsEdgeInternalToPolygon(FEdgeID EdgeID,FPolygonID PolygonID) { return default; }
	public  void GetEdgeConnectedTriangles(FEdgeID EdgeID,TArray<FTriangleID> OutConnectedTriangleIDs) {}
	public  int GetNumEdgeConnectedTriangles(FEdgeID EdgeID) { return default; }
	public  void GetEdgeConnectedPolygons(FEdgeID EdgeID,TArray<FPolygonID> OutConnectedPolygonIDs) {}
	public  int GetNumEdgeConnectedPolygons(FEdgeID EdgeID) { return default; }
	public  FVertexID GetEdgeVertex(FEdgeID EdgeID,int VertexNumber) { return default; }
	public  void GetEdgeVertices(FEdgeID EdgeID,TArray<FVertexID> OutVertexIDs) {}
	public  FPolygonID GetTrianglePolygon(FTriangleID TriangleID) { return default; }
	public  FPolygonGroupID GetTrianglePolygonGroup(FTriangleID TriangleID) { return default; }
	public  bool IsTrianglePartOfNgon(FTriangleID TriangleID) { return default; }
	public  void GetTriangleVertexInstances(FTriangleID TriangleID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	public  FVertexInstanceID GetTriangleVertexInstance(FTriangleID TriangleID,int Index) { return default; }
	public  void GetTriangleVertices(FTriangleID TriangleID,TArray<FVertexID> OutVertexIDs) {}
	public  void GetTriangleEdges(FTriangleID TriangleID,TArray<FEdgeID> OutEdgeIDs) {}
	public  void GetTriangleAdjacentTriangles(FTriangleID TriangleID,TArray<FTriangleID> OutTriangleIDs) {}
	public  FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID,FVertexID VertexID) { return default; }
	public  void GetPolygonTriangles(FPolygonID PolygonID,TArray<FTriangleID> OutTriangleIDs) {}
	public  int GetNumPolygonTriangles(FPolygonID PolygonID) { return default; }
	public  void GetPolygonVertexInstances(FPolygonID PolygonID,TArray<FVertexInstanceID> OutVertexInstanceIDs) {}
	public  int GetNumPolygonVertices(FPolygonID PolygonID) { return default; }
	public  void GetPolygonVertices(FPolygonID PolygonID,TArray<FVertexID> OutVertexIDs) {}
	public  void GetPolygonPerimeterEdges(FPolygonID PolygonID,TArray<FEdgeID> OutEdgeIDs) {}
	public  void GetPolygonInternalEdges(FPolygonID PolygonID,TArray<FEdgeID> OutEdgeIDs) {}
	public  int GetNumPolygonInternalEdges(FPolygonID PolygonID) { return default; }
	public  void GetPolygonAdjacentPolygons(FPolygonID PolygonID,TArray<FPolygonID> OutPolygonIDs) {}
	public  FPolygonGroupID GetPolygonPolygonGroup(FPolygonID PolygonID) { return default; }
	public  FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID,FVertexID VertexID) { return default; }
	public  void SetPolygonVertexInstances(FPolygonID PolygonID,TArray<FVertexInstanceID> VertexInstanceIDs) {}
	public  void SetPolygonPolygonGroup(FPolygonID PolygonID,FPolygonGroupID PolygonGroupID) {}
	public  void ReversePolygonFacing(FPolygonID PolygonID) {}
	public  void ComputePolygonTriangulation(FPolygonID PolygonID) {}
	public  void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID,TArray<FPolygonID> OutPolygonIDs) {}
	public  int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID) { return default; }
}
