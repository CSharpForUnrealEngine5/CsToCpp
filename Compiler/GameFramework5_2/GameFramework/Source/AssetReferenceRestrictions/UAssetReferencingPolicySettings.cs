#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Asset Referencing Policy, these settings are used to determine which plugins and game folders can reference content from each other</summary>
[CppInclude("AssetReferencingPolicySettings.h")]
public partial class UAssetReferencingPolicySettings : UDeveloperSettings {
	///<summary>Settings/rules for engine plugins</summary>
	public FARPDomainSettingsForPlugins EnginePlugins;
	///<summary>Settings/rules for project plugins</summary>
	public FARPDomainSettingsForPlugins ProjectPlugins;
	///<summary>The default rules for project content (if a more specific rule doesn&#39;t apply)</summary>
	public FARPDefaultProjectDomainRules DefaultProjectContentRule;
	///<summary>List of additional domains to carve out from the project content folder</summary>
	public TArray<FARPDomainDefinitionByContentRoot> AdditionalDomains;
	///<summary>GetListOfDomains_All</summary>
	public  TArray<string> GetListOfDomains_All() { return default; }
	///<summary>GetListOfDomains_NoEngine</summary>
	public  TArray<string> GetListOfDomains_NoEngine() { return default; }
	///<summary>GetListOfDomains_NoEngineOrGame</summary>
	public  TArray<string> GetListOfDomains_NoEngineOrGame() { return default; }
	///<summary>GetListOfDomains_NoPluginsOrEngine</summary>
	public  TArray<string> GetListOfDomains_NoPluginsOrEngine() { return default; }
}
