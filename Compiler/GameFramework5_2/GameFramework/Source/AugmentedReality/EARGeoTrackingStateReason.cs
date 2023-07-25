#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
public enum EARGeoTrackingStateReason {
	None=0,
	NotAvailableAtLocation=1,
	NeedLocationPermissions=2,
	DevicePointedTooLow=3,
	WorldTrackingUnstable=4,
	WaitingForLocation=5,
	GeoDataNotLoaded=6,
	VisualLocalizationFailed=7,
	WaitingForAvailabilityCheck=8,
}
