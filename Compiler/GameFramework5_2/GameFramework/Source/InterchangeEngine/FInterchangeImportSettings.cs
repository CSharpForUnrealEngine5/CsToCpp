#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeImportSettings {
// InterchangeImportSettings
	public TMap<string,FInterchangePipelineStack> PipelineStacks;
	public string DefaultPipelineStack;
	public TSoftObjectPtr<UClass> PipelineConfigurationDialogClass;
	public bool bShowPipelineStacksConfigurationDialog;
}
