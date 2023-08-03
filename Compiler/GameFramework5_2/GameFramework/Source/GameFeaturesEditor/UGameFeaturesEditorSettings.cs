#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeaturesEditorSettings.h")]
public partial class UGameFeaturesEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Array of Plugin templates. Allows projects to specify reusable plugin templates for the plugin creation wizard.</summary>
	public TArray<FPluginTemplateData> PluginTemplates;
}
