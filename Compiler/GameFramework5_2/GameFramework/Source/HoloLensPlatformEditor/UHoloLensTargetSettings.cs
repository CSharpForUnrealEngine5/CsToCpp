#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the HoloLens target platform.</summary>
[CppInclude("HoloLensTargetSettings.h")]
public partial class UHoloLensTargetSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When checked, a build that can be run via emulation is added</summary>
	public bool bBuildForEmulation;
	///<summary>When the box checked the final bundle has binaries of ARM64 OSes.</summary>
	public bool bBuildForDevice;
	///<summary>bUseNameForLogo</summary>
	public bool bUseNameForLogo;
	///<summary>Controls whether to use the retail Windows Store environment for license checks.  This must be turned on</summary>
	public bool bBuildForRetailWindowsStore;
	///<summary>bAutoIncrementVersion</summary>
	public bool bAutoIncrementVersion;
	///<summary>bShouldCreateAppInstaller</summary>
	public bool bShouldCreateAppInstaller;
	///<summary>AppInstallerInstallationURL</summary>
	public string AppInstallerInstallationURL;
	///<summary>0 will check on every app launch.</summary>
	public int HoursBetweenUpdateChecks;
	///<summary>bEnablePIXProfiling</summary>
	public bool bEnablePIXProfiling;
	///<summary>TileBackgroundColor</summary>
	public FColor TileBackgroundColor;
	///<summary>SplashScreenBackgroundColor</summary>
	public FColor SplashScreenBackgroundColor;
	///<summary>PerCultureResources</summary>
	public TArray<FHoloLensCorePackageLocalizedResources> PerCultureResources;
	///<summary>Identifies the device family that your package will target.</summary>
	public string TargetDeviceFamily;
	///<summary>Minimum version of the HoloLens platform required to run this title.</summary>
	public string MinimumPlatformVersion;
	///<summary>Specifies the maximum version of the universal platform on which the</summary>
	public string MaximumPlatformVersionTested;
	///<summary>Used by the HoloLens to indicate triangle density when generating meshes. Defaults to 500 per cubic meter</summary>
	public float MaxTrianglesPerCubicMeter;
	///<summary>Used by the HoloLens to indicate how large (in meters) of a volume to use for generating meshes. Defaults to a 20m cube</summary>
	public float SpatialMeshingVolumeSize;
	///<summary>The compiler version to use for this project. May be different to the chosen IDE.</summary>
	public ECompilerVersion CompilerVersion;
	///<summary>Windows10SDKVersion</summary>
	public string Windows10SDKVersion;
	///<summary>List of supported &lt;Capability&gt;&lt;Capability&gt; elements for the application.</summary>
	public TArray<string> CapabilityList;
	///<summary>List of supported &lt;Capability&gt;&lt;DeviceCapability&gt; elements for the application.</summary>
	public TArray<string> DeviceCapabilityList;
	///<summary>List of supported &lt;Capability&gt;&lt;uap:Capability&gt; elements for the application.</summary>
	public TArray<string> UapCapabilityList;
	///<summary>List of supported &lt;Capability&gt;&lt;uap2:Capability&gt; elements for the application.</summary>
	public TArray<string> Uap2CapabilityList;
	///<summary>Set default capabilities (InternetClientServer and PrivateNetworkClientServer) for the application.</summary>
	public bool bSetDefaultCapabilities;
	///<summary>Which of the currently enabled spatialization plugins to use.</summary>
	public string SpatializationPlugin;
	///<summary>Which of the currently enabled source data override plugins to use.</summary>
	public string SourceDataOverridePlugin;
	///<summary>Which of the currently enabled reverb plugins to use.</summary>
	public string ReverbPlugin;
	///<summary>Which of the currently enabled occlusion plugins to use.</summary>
	public string OcclusionPlugin;
	///<summary>Quality Level to COOK SoundCues at (if set, all other levels will be stripped by the cooker).</summary>
	public int SoundCueCookQualityIndex;
}
