namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeImportSettings {
	public TMap<FName,FInterchangePipelineStack> PipelineStacks;
	public FName DefaultPipelineStack;
	public TSoftObjectPtr<UClass> PipelineConfigurationDialogClass;
	public bool bShowPipelineStacksConfigurationDialog;
}
