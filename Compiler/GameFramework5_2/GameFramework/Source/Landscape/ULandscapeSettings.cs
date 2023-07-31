#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSettings.h")]
public partial class ULandscapeSettings : UDeveloperSettings {
	///<summary>This option controls the maximum editing layers that can be added to a Landscape</summary>
	public int MaxNumberOfLayers;
	///<summary>LandscapeDirtyingMode</summary>
	public ELandscapeDirtyingMode LandscapeDirtyingMode;
	///<summary>SideResolutionLimit</summary>
	public int SideResolutionLimit;
	///<summary>Default Landscape Material will be prefilled when creating a new landscape.</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultLandscapeMaterial;
	///<summary>Default Layer Info Object</summary>
	public TSoftObjectPtr<ULandscapeLayerInfoObject> DefaultLayerInfoObject;
	///<summary>bRestrictiveMode</summary>
	public bool bRestrictiveMode;
}
