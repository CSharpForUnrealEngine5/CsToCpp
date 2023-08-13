namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We use this object to display plugin properties using details view.</summary>
[CppInclude("PluginMetadataObject.h")]
public partial class UPluginMetadataObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Version number for the plugin.  The version number must increase with every version of the plugin, so that the system</summary>
	public int Version;
	///<summary>Name of the version for this plugin.  This is the front-facing part of the version number.  It doesn&#39;t need to match</summary>
	public string VersionName;
	///<summary>Friendly name of the plugin</summary>
	public string FriendlyName;
	///<summary>Description of the plugin</summary>
	public string Description;
	///<summary>The category that this plugin belongs to</summary>
	public string Category;
	///<summary>The company or individual who created this plugin.  This is an optional field that may be displayed in the user interface.</summary>
	public string CreatedBy;
	///<summary>Hyperlink URL string for the company or individual who created this plugin.  This is optional.</summary>
	public string CreatedByURL;
	///<summary>Documentation URL string.</summary>
	public string DocsURL;
	///<summary>Marketplace URL string.</summary>
	public string MarketplaceURL;
	///<summary>Support URL/email for this plugin. Email addresses must be prefixed with &#39;mailto:&#39;</summary>
	public string SupportURL;
	///<summary>Can this plugin contain content?</summary>
	public bool bCanContainContent;
	///<summary>Marks the plugin as beta in the UI</summary>
	public bool bIsBetaVersion;
	///<summary>If true, the plugin will be enabled by default without needing to modify the project file. This cannot be changed while the editor is running</summary>
	public bool bIsEnabledByDefault;
	///<summary>If true, the plugin will not load at startup and must be explicitly loaded. This cannot be changed while the editor is running</summary>
	public bool bExplicitlyLoaded;
	///<summary>Plugins used by this plugin</summary>
	public TArray<FPluginReferenceMetadata> Plugins;
	///<summary>GetAvailablePluginDependencies</summary>
	public TArray<string> GetAvailablePluginDependencies() { return default; }
}
