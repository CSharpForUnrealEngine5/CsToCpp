#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/DisplayClusterLightCardEditorSettings.h")]
///<summary>Default settings shared across users of the project</summary>
public partial class UDisplayClusterLightCardEditorProjectSettings : UObject {
// DisplayClusterLightCardEditorProjectSettings
	public FDirectoryPath LightCardTemplateDefaultPath;
	public TSoftObjectPtr<UDisplayClusterLightCardTemplate> DefaultLightCardTemplate;
	public TSoftObjectPtr<UDisplayClusterLightCardTemplate> DefaultFlagTemplate;
	public bool bDisplayLightCardLabels;
	public float LightCardLabelScale;
}
