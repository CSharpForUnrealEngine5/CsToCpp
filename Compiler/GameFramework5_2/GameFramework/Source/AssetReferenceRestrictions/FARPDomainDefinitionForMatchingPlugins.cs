#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionForMatchingPlugins {
	public string DisplayName;
	public string ErrorMessageIfUsedElsewhere;
	public EARPPluginMatchMode MatchRule;
	public string PluginPathPrefix;
	public string PluginCategoryPrefix;
	public TArray<string> CanReferenceTheseDomains;
}
