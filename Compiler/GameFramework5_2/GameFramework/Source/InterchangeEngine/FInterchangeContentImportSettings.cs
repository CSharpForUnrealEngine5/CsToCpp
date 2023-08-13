namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeProjectSettings.h")]
public partial struct FInterchangeContentImportSettings {
	public TMap<EInterchangeTranslatorAssetType,string> DefaultPipelineStackOverride;
	public TMap<EInterchangeTranslatorAssetType,bool> ShowPipelineStacksConfigurationDialogOverride;
}
