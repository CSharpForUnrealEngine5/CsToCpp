#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the implementation responsible for executing the rendering of</summary>
[CppInclude("MoviePipelinePIEExecutor.h")]
public partial class UMoviePipelinePIEExecutor : UMoviePipelineLinearExecutorBase {
	public static UClass StaticClass() {return default;}
	///<summary>SetInitializationTime</summary>
	public  void SetInitializationTime(FDateTime InInitializationTime) {}
	///<summary>Should it render without any UI elements showing up (such as the rendering progress window)?</summary>
	public  void SetIsRenderingOffscreen(bool bInRenderOffscreen) {}
	///<summary>Will it render without any UI elements showing up (such as the rendering progress window)?</summary>
	public  bool IsRenderingOffscreen() { return default; }
	///<summary>OnIndividualJobFinishedDelegate</summary>
	public FOnMoviePipelineIndividualJobFinished OnIndividualJobFinishedDelegate;
	///<summary>Called after each job is finished in the queue. Params struct contains an output of all files written.</summary>
	public FMoviePipelineWorkFinished OnIndividualJobWorkFinishedDelegate;
	///<summary>Called after each shot is finished for a particular render. Params struct contains an output of files written for this shot.</summary>
	public FMoviePipelineWorkFinished OnIndividualShotWorkFinishedDelegate;
	///<summary>Called right before this job is used to initialize a UMoviePipeline.</summary>
	public FOnMoviePipelineIndividualJobStarted OnIndividualJobStartedDelegate;
}
