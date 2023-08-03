#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is use to pass override pipelines in the ImportAssetTask Options member</summary>
[CppInclude("InterchangeManager.h")]
public partial class UInterchangePipelineStackOverride : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OverridePipelines</summary>
	public TArray<UInterchangePipelineBase> OverridePipelines;
}
