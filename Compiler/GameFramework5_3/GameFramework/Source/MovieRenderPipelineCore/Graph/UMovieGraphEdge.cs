namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphEdge.h")]
public partial class UMovieGraphEdge : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InputPin</summary>
	public UMovieGraphPin InputPin;
	///<summary>OutputPin</summary>
	public UMovieGraphPin OutputPin;
}
