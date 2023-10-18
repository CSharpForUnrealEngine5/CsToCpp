namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which represents another graph asset. Inputs/outputs on this subgraph will update if the underlying graph</summary>
[CppInclude("Graph/Nodes/MovieGraphSubgraphNode.h")]
public partial class UMovieGraphSubgraphNode : UMovieGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the graph asset this subgraph points to.</summary>
	public void SetSubGraphAsset(TSoftObjectPtr<UMovieGraphConfig> InSubgraphAsset) {}
	///<summary>Gets the graph asset this subgraph points to.</summary>
	public UMovieGraphConfig GetSubgraphAsset() { return default; }
	///<summary>SubgraphAsset</summary>
	public TSoftObjectPtr<UMovieGraphConfig> SubgraphAsset;
}
