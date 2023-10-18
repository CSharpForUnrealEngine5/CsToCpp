namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The minimum amount of data we need to serialize to be able to reconstruct the graph as it was.</summary>
[CppInclude("Graph/Graph.h")]
public partial struct FSerializableGraph {
	public FGraphProperties Properties;
	public TArray<FGraphVertexHandle> Vertices;
	public TMap<FGraphEdgeHandle,FSerializedEdgeData> Edges;
	public TMap<FGraphIslandHandle,FSerializedIslandData> Islands;
}
