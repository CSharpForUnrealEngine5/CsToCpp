namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a property that currently is (or can be) exposed on a node.</summary>
[CppInclude("Graph/MovieGraphNode.h")]
public partial struct FMovieGraphPropertyInfo {
	public FName Name;
	public bool bIsDynamicProperty;
	public EMovieGraphValueType ValueType;
}
