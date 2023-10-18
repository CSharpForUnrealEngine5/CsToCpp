namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphTraversalContext.h")]
public partial struct FMovieGraphTraversalContext {
	public FName RootBranch;
	public int ShotIndex;
	public int ShotCount;
	public UMoviePipelineExecutorJob Job;
	public UMovieGraphConfig RootGraph;
	public FMovieGraphRenderDataIdentifier RenderDataIdentifier;
	public FMovieGraphTimeStepData Time;
}
