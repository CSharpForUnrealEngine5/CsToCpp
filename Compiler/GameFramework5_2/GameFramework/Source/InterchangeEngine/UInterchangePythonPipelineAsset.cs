#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePythonPipelineBase.h")]
///<summary>* This class is a helper class for python pipeline. It allow picker to filter correctly the content browser instance we want to support</summary>
public partial class UInterchangePythonPipelineAsset : UObject {
// InterchangePythonPipelineAsset
	public TSoftObjectPtr<UClass> PythonClass;
	public UInterchangePythonPipelineBase GeneratedPipeline;
	public string JsonDefaultProperties;
}
