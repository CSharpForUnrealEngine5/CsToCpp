#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionForMatchingPlugins {
// ARPDomainDefinitionForMatchingPlugins
	public string DisplayName;
	public string ErrorMessageIfUsedElsewhere;
	public EARPPluginMatchMode MatchRule;
	public string PluginPathPrefix;
	public string PluginCategoryPrefix;
	public TArray<string> CanReferenceTheseDomains;
}
