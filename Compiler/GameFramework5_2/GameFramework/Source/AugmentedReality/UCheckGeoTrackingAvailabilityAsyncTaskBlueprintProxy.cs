#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Blueprint async task to check Geo tracking availability.</summary>
public partial class UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
// CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy
	public  void FGeoTrackingAvailabilityDelegate(bool bIsAvailable,string Error) {}
	public FGeoTrackingAvailabilityDelegate OnSuccess;
	public FGeoTrackingAvailabilityDelegate OnFailed;
	public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailability(UObject WorldContextObject) { return default; }
	public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailabilityAtLocation(UObject WorldContextObject,float Longitude,float Latitude) { return default; }
}
