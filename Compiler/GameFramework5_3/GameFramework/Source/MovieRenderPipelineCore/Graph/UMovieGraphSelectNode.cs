namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node which creates a condition that selects from a set of input branches.</summary>
[CppInclude("Graph/Nodes/MovieGraphSelectNode.h")]
public partial class UMovieGraphSelectNode : UMovieGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The values of options which can be selected.</summary>
	public TArray<string> SelectOptions;
	///<summary>The value of the option which has been selected.</summary>
	public string SelectedOption;
	///<summary>A description of what this select is doing.</summary>
	public string Description;
}
