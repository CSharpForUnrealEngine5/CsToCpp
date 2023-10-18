namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A variable that can be used inside the graph. Most variables are created by the user, and can have their value</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial class UMovieGraphVariable : UMovieGraphMember {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this variable represents a global variable.</summary>
	public bool bIsGlobal;
}
