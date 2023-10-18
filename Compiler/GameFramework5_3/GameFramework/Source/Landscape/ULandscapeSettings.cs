namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSettings.h")]
public partial class ULandscapeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>This option controls the maximum editing layers that can be added to a Landscape</summary>
	public int MaxNumberOfLayers;
	///<summary>Maximum Dimension of Landscape in Components</summary>
	public int MaxComponents;
	///<summary>Maximum Size of Import Image Cache in MB</summary>
	public uint MaxImageImportCacheSizeMegaBytes;
	///<summary>Exponent for the Paint Tool Strength</summary>
	public float PaintStrengthGamma;
	///<summary>Disable Painting Startup Slowdown</summary>
	public bool bDisablePaintingStartupSlowdown;
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
