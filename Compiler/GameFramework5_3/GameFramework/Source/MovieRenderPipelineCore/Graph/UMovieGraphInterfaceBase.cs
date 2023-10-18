namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common base class for input/output members on the graph.</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial class UMovieGraphInterfaceBase : UMovieGraphMember {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this interface member represents a branch. If not a branch, then a value is associated with it.</summary>
	public bool bIsBranch;
}
