namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UGraph is a collection of nodes and edges. This graph representation</summary>
[CppInclude("Graph/Graph.h")]
public partial class UGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Vertices</summary>
	public TMap<FGraphVertexHandle,UGraphVertex> Vertices;
	///<summary>Edges</summary>
	public TMap<FGraphEdgeHandle,UGraphEdge> Edges;
	///<summary>Islands</summary>
	public TMap<FGraphIslandHandle,UGraphIsland> Islands;
}
