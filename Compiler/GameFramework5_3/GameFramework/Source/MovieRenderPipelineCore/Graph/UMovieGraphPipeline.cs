namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphPipeline.h")]
public partial class UMovieGraphPipeline : UMoviePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize</summary>
	public void Initialize(UMoviePipelineExecutorJob InJob,FMovieGraphInitConfig InitConfig) {}
	///<summary>GetCurrentJob</summary>
	public UMoviePipelineExecutorJob GetCurrentJob() { return default; }
	///<summary>Returns the time this movie pipeline was initialized at.</summary>
	public FDateTime GetInitializationTime() { return default; }
	///<summary>Override the time this movie pipeline was initialized at. This can be used for render farms</summary>
	public void SetInitializationTime(FDateTime InDateTime) {}
	///<summary>OnMoviePipelineFinishedImpl</summary>
	public virtual void OnMoviePipelineFinishedImpl() {}
	///<summary>GraphTimeStepInstance</summary>
	public UMovieGraphTimeStepBase GraphTimeStepInstance;
	///<summary>GraphRendererInstance</summary>
	public UMovieGraphRendererBase GraphRendererInstance;
	///<summary>GraphDataSourceInstance</summary>
	public UMovieGraphDataSourceBase GraphDataSourceInstance;
	///<summary>CurrentJob</summary>
	public UMoviePipelineExecutorJob CurrentJob;
	///<summary>ActiveShotList</summary>
	public TArray<UMoviePipelineExecutorShot> ActiveShotList;
	///<summary>An array of Node CDOs that we sent data through to write data to disk.</summary>
	public TSet<UMovieGraphFileOutputNode> OutputNodesDataSentTo;
}
