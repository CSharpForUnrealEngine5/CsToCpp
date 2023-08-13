namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionForMatchingPlugins {
	public FText DisplayName;
	public FText ErrorMessageIfUsedElsewhere;
	public EARPPluginMatchMode MatchRule;
	public string PluginPathPrefix;
	public string PluginCategoryPrefix;
	public TArray<string> CanReferenceTheseDomains;
}
