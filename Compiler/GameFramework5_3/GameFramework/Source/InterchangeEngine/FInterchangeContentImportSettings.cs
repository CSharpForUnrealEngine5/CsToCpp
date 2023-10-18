namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeContentImportSettings {
	public TMap<EInterchangeTranslatorAssetType,FName> DefaultPipelineStackOverride;
	public TMap<EInterchangeTranslatorAssetType,bool> ShowPipelineStacksConfigurationDialogOverride;
}
