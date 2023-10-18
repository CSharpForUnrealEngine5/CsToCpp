namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is use to pass override pipelines in the ImportAssetTask Options member</summary>
[CppInclude("InterchangeManager.h")]
public partial class UInterchangePipelineStackOverride : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OverridePipelines</summary>
	public TArray<FSoftObjectPath> OverridePipelines;
	///<summary>AddPythonPipeline</summary>
	public void AddPythonPipeline(UInterchangePythonPipelineBase PipelineBase) {}
	///<summary>AddBlueprintPipeline</summary>
	public void AddBlueprintPipeline(UInterchangeBlueprintPipelineBase PipelineBase) {}
	///<summary>AddPipeline</summary>
	public void AddPipeline(UInterchangePipelineBase PipelineBase) {}
}
