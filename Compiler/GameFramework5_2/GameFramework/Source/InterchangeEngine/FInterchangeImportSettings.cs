#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeImportSettings {
	public TMap<string,FInterchangePipelineStack> PipelineStacks;
	public string DefaultPipelineStack;
	public TSoftObjectPtr<UClass> PipelineConfigurationDialogClass;
	public bool bShowPipelineStacksConfigurationDialog;
}
