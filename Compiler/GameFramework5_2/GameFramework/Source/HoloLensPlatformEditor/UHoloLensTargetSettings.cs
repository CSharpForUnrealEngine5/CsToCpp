#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoloLensTargetSettings.h")]
///<summary>Implements the settings for the HoloLens target platform.</summary>
public partial class UHoloLensTargetSettings : UObject {
// HoloLensTargetSettings
	public bool bBuildForEmulation;
	public bool bBuildForDevice;
	public bool bUseNameForLogo;
	public bool bBuildForRetailWindowsStore;
	public bool bAutoIncrementVersion;
	public bool bShouldCreateAppInstaller;
	public string AppInstallerInstallationURL;
	public int HoursBetweenUpdateChecks;
	public bool bEnablePIXProfiling;
	public FColor TileBackgroundColor;
	public FColor SplashScreenBackgroundColor;
	public TArray<FHoloLensCorePackageLocalizedResources> PerCultureResources;
	public string TargetDeviceFamily;
	public string MinimumPlatformVersion;
	public string MaximumPlatformVersionTested;
	public float MaxTrianglesPerCubicMeter;
	public float SpatialMeshingVolumeSize;
	public ECompilerVersion CompilerVersion;
	public string Windows10SDKVersion;
	public TArray<string> CapabilityList;
	public TArray<string> DeviceCapabilityList;
	public TArray<string> UapCapabilityList;
	public TArray<string> Uap2CapabilityList;
	public bool bSetDefaultCapabilities;
	public string SpatializationPlugin;
	public string SourceDataOverridePlugin;
	public string ReverbPlugin;
	public string OcclusionPlugin;
	public int SoundCueCookQualityIndex;
}
