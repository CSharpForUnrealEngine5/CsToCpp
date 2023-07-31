#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineConfigurationBase.h")]
public partial class UInterchangePipelineConfigurationBase : UObject {
	///<summary>Non virtual helper to allow blueprint to implement event base function to implement the ShowPipelineConfigurationDialog,</summary>
	public  EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog(TArray<FInterchangeStackInfo> PipelineStacks,TArray<UInterchangePipelineBase> OutPipelines,UInterchangeSourceData SourceData) { return default; }
	///<summary>Non virtual helper to allow blueprint to implement event base function to implement the ShowPipelineConfigurationDialog,</summary>
	public  EInterchangePipelineConfigurationDialogResult ScriptedShowScenePipelineConfigurationDialog(TArray<FInterchangeStackInfo> PipelineStacks,TArray<UInterchangePipelineBase> OutPipelines,UInterchangeSourceData SourceData) { return default; }
	///<summary>Non virtual helper to allow blueprint to implement event base function to implement the ShowPipelineConfigurationDialog,</summary>
	public  EInterchangePipelineConfigurationDialogResult ScriptedShowReimportPipelineConfigurationDialog(TArray<FInterchangeStackInfo> PipelineStacks,TArray<UInterchangePipelineBase> OutPipelines,UInterchangeSourceData SourceData) { return default; }
}
