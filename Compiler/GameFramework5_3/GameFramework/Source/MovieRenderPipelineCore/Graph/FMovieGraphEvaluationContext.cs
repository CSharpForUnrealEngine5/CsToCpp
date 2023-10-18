namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This stores short-term information needed during traversal of the graph</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial struct FMovieGraphEvaluationContext {
	public FMovieGraphTraversalContext UserContext;
	public TSet<UMovieGraphNode> VisitedNodes;
	public UMovieGraphPin PinBeingFollowed;
	public TArray<UMovieGraphSubgraphNode> SubgraphStack;
}
