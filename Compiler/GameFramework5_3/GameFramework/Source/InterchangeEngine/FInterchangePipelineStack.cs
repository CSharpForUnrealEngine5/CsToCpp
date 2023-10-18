namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangePipelineStack {
	public TArray<FSoftObjectPath> Pipelines;
	public TArray<FInterchangeTranslatorPipelines> PerTranslatorPipelines;
}
