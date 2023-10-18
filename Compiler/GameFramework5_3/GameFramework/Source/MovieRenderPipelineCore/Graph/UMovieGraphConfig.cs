namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the runtime representation of the UMoviePipelineEdGraph which contains the actual strongly</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial class UMovieGraphConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new variable member with default values to the graph. The new variable will have a base name of</summary>
	public UMovieGraphVariable AddVariable(FName InCustomBaseName/*=NAME_None*/) { return default; }
	///<summary>Gets all variables that are available to be used in the graph. Global variables can optionally be included if</summary>
	public TArray<UMovieGraphVariable> GetVariables(bool bIncludeGlobal/*=false*/) { return default; }
	///<summary>Given a user-defined evaluation context, evaluate the graph and build a &quot;flattened&quot; list of settings for each branch discovered.</summary>
	public UMovieGraphEvaluatedConfig CreateFlattenedGraph(FMovieGraphTraversalContext InContext) { return default; }
	///<summary>AllNodes</summary>
	public TArray<UMovieGraphNode> AllNodes;
	///<summary>InputNode</summary>
	public UMovieGraphNode InputNode;
	///<summary>OutputNode</summary>
	public UMovieGraphNode OutputNode;
	///<summary>Not strongly typed to avoid a circular dependency between the editor only module</summary>
	public UEdGraph PipelineEdGraph;
	///<summary>All variables (user and global) which are available for use in the graph.</summary>
	public TArray<UMovieGraphVariable> Variables;
	///<summary>All inputs which have been defined on the graph.</summary>
	public TArray<UMovieGraphInput> Inputs;
	///<summary>All outputs which have been defined on the graph.</summary>
	public TArray<UMovieGraphOutput> Outputs;
	///<summary>Nodes which are only useful in the editor (like comments) and have no runtime equivalent</summary>
	public TArray<UObject> EditorOnlyNodes;
}
