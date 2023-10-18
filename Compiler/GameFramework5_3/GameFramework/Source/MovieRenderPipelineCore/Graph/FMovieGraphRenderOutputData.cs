namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphDataTypes.h")]
public partial struct FMovieGraphRenderOutputData {
	public TWeakObjectPtr<UMoviePipelineExecutorShot> Shot;
	public TMap<FMovieGraphRenderDataIdentifier,FMovieGraphRenderPassOutputData> RenderPassData;
}
