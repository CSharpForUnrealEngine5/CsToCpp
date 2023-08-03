#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This class is a helper class for python pipeline. It allow picker to filter correctly the content browser instance we want to support</summary>
[CppInclude("InterchangePythonPipelineBase.h")]
public partial class UInterchangePythonPipelineAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The python class we want to use has a pipeline</summary>
	public TSoftObjectPtr<UClass> PythonClass;
	///<summary>The transient pipeline we generate when we load the python pipeline</summary>
	public UInterchangePythonPipelineBase GeneratedPipeline;
	///<summary>JsonDefaultProperties</summary>
	public string JsonDefaultProperties;
}
