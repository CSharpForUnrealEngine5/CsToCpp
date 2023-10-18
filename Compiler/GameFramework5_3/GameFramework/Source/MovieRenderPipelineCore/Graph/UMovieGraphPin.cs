namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphPin.h")]
public partial class UMovieGraphPin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The node that this pin belongs to.</summary>
	public UMovieGraphNode Node;
	///<summary>Properties</summary>
	public FMovieGraphPinProperties Properties;
	///<summary>A list of edges between pins. This is marked as TextExportTransient so that when we copy/paste nodes,</summary>
	public TArray<UMovieGraphEdge> Edges;
}
