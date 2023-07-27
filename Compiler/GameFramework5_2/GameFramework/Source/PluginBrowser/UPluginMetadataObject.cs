#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PluginMetadataObject.h")]
///<summary>We use this object to display plugin properties using details view.</summary>
public partial class UPluginMetadataObject : UObject {
// PluginMetadataObject
	public int Version;
	public string VersionName;
	public string FriendlyName;
	public string Description;
	public string Category;
	public string CreatedBy;
	public string CreatedByURL;
	public string DocsURL;
	public string MarketplaceURL;
	public string SupportURL;
	public bool bCanContainContent;
	public bool bIsBetaVersion;
	public bool bIsEnabledByDefault;
	public bool bExplicitlyLoaded;
	public TArray<FPluginReferenceMetadata> Plugins;
	public  TArray<string> GetAvailablePluginDependencies() { return default; }
}
