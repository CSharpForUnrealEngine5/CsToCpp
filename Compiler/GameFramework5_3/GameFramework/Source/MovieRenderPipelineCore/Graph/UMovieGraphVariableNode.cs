namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which gets the value of a variable which has been defined on the graph.</summary>
[CppInclude("Graph/Nodes/MovieGraphVariableNode.h")]
public partial class UMovieGraphVariableNode : UMovieGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The underlying graph variable this node represents.</summary>
	public UMovieGraphVariable GraphVariable;
	///<summary>The properties for the output pin on this node.</summary>
	public FMovieGraphPinProperties OutputPin;
}
