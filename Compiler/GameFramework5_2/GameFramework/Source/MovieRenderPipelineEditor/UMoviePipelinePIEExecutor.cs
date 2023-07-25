#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelinePIEExecutor.h")]
///<summary>This is the implementation responsible for executing the rendering of</summary>
public partial class UMoviePipelinePIEExecutor : UMoviePipelineLinearExecutorBase {
// MoviePipelinePIEExecutor
	public void SetInitializationTime(FDateTime InInitializationTime) {}
	public void SetIsRenderingOffscreen(bool bInRenderOffscreen) {}
	public bool IsRenderingOffscreen() { return default; }
	public FOnMoviePipelineIndividualJobFinished OnIndividualJobFinishedDelegate;
	public FMoviePipelineWorkFinished OnIndividualJobWorkFinishedDelegate;
	public FMoviePipelineWorkFinished OnIndividualShotWorkFinishedDelegate;
	public FOnMoviePipelineIndividualJobStarted OnIndividualJobStartedDelegate;
}
