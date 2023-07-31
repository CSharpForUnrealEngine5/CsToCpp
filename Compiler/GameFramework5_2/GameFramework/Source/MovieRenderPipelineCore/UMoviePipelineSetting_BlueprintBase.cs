#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for all Movie Render Pipeline settings which can be implemented in Blueprints. This features</summary>
[CppInclude("MoviePipelineSettingBlueprintBase.h")]
public partial class UMoviePipelineSetting_BlueprintBase : UMoviePipelineSetting {
	///<summary>ReceiveSetupForPipelineImpl</summary>
	public  void ReceiveSetupForPipelineImpl(UMoviePipeline InPipeline) {}
	///<summary>ReceiveTeardownForPipelineImpl</summary>
	public  void ReceiveTeardownForPipelineImpl(UMoviePipeline InPipeline) {}
	///<summary>ReceiveGetFormatArguments</summary>
	public  FMoviePipelineFormatArgs ReceiveGetFormatArguments(FMoviePipelineFormatArgs InOutFormatArgs) { return default; }
	///<summary>Tick</summary>
	public  void OnEngineTickBeginFrame() {}
	///<summary>ReceiveGetFooterText</summary>
	public  string ReceiveGetFooterText(UMoviePipelineExecutorJob InJob) { return default; }
	///<summary>CategoryText</summary>
	public string CategoryText;
	///<summary>bIsValidOnPrimary</summary>
	public bool bIsValidOnPrimary;
	///<summary>bIsValidOnShots</summary>
	public bool bIsValidOnShots;
	///<summary>bCanBeDisabled</summary>
	public bool bCanBeDisabled;
	///<summary>bIsValidOnMaster_DEPRECATED</summary>
	public bool bIsValidOnMaster_DEPRECATED;
}
