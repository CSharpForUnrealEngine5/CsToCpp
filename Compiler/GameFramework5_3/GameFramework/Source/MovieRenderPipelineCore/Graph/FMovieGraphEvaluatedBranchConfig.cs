namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A flattened list of configuration values for a given Graph Branch. For named branches, this includes the &quot;Globals&quot;</summary>
[CppInclude("Graph/MovieGraphConfig.h")]
public partial struct FMovieGraphEvaluatedBranchConfig {
	public TMap<string,FMovieGraphEvaluatedSettingsStack> NamedNodes;
}
