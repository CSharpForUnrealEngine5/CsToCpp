#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
public partial struct FCoarseLocalizationSettings {
	public bool bEnable;
	public bool bEnableGPS;
	public bool bEnableWifi;
	public TArray<string> BLEBeaconUUIDs;
}
