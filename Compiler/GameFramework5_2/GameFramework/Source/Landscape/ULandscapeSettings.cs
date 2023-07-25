#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSettings.h")]
public partial class ULandscapeSettings : UDeveloperSettings {
// LandscapeSettings
	public int MaxNumberOfLayers;
	public ELandscapeDirtyingMode LandscapeDirtyingMode;
	public int SideResolutionLimit;
	public TSoftObjectPtr<UMaterialInterface> DefaultLandscapeMaterial;
	public TSoftObjectPtr<ULandscapeLayerInfoObject> DefaultLayerInfoObject;
	public bool bRestrictiveMode;
}
