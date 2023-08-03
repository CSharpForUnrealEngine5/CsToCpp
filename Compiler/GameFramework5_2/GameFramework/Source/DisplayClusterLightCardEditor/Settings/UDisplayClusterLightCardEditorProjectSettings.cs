#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default settings shared across users of the project</summary>
[CppInclude("Settings/DisplayClusterLightCardEditorSettings.h")]
public partial class UDisplayClusterLightCardEditorProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default path to save new light card templates</summary>
	public FDirectoryPath LightCardTemplateDefaultPath;
	///<summary>The default template to use when creating a new light card</summary>
	public TSoftObjectPtr<UDisplayClusterLightCardTemplate> DefaultLightCardTemplate;
	///<summary>The default template to use when creating a new flag</summary>
	public TSoftObjectPtr<UDisplayClusterLightCardTemplate> DefaultFlagTemplate;
	///<summary>Whether light card labels should be displayed. Handled through the light card editor</summary>
	public bool bDisplayLightCardLabels;
	///<summary>The scale to use for light card labels</summary>
	public float LightCardLabelScale;
}
