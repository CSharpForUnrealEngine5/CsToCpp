namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An evaluated config for the current frame. Each named branch (including Globals) has its own</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial class UMovieGraphEvaluatedConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Mapping between named branches (at the root of the config) and their evaluated values.</summary>
	public TMap<FName,FMovieGraphEvaluatedBranchConfig> BranchConfigMapping;
}
