namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for schema actions in the graph.</summary>
[CppInclude("Graph/MovieGraphSchema.h")]
public partial struct FMovieGraphSchemaAction {
	public UObject ActionTarget;
	public UClass NodeClass;
}
