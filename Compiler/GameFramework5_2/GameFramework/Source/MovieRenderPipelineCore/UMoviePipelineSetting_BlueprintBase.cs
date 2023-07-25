#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineSettingBlueprintBase.h")]
///<summary>A base class for all Movie Render Pipeline settings which can be implemented in Blueprints. This features</summary>
public partial class UMoviePipelineSetting_BlueprintBase : UMoviePipelineSetting {
// MoviePipelineSetting_BlueprintBase
	public void ReceiveSetupForPipelineImpl(UObject InPipeline) {}
	public void ReceiveTeardownForPipelineImpl(UObject InPipeline) {}
	public FMoviePipelineFormatArgs ReceiveGetFormatArguments(FMoviePipelineFormatArgs InOutFormatArgs) { return default; }
	public void OnEngineTickBeginFrame() {}
	public string ReceiveGetFooterText(UObject InJob) { return default; }
	public string CategoryText;
	public bool bIsValidOnPrimary;
	public bool bIsValidOnShots;
	public bool bCanBeDisabled;
	public bool bIsValidOnMaster_DEPRECATED;
}
