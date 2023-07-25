#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
public partial struct FCoarseLocalizationSettings {
// CoarseLocalizationSettings
	public bool bEnable;
	public bool bEnableGPS;
	public bool bEnableWifi;
	public TArray<string> BLEBeaconUUIDs;
}
