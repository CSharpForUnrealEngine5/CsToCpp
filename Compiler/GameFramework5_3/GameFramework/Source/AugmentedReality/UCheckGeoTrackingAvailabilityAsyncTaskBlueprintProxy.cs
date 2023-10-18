namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint async task to check Geo tracking availability.</summary>
[CppInclude("ARGeoTrackingSupport.h")]
public partial class UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
	public static UClass StaticClass() {return default;}
	///<summary>FGeoTrackingAvailabilityDelegate</summary>
	public void FGeoTrackingAvailabilityDelegate(bool bIsAvailable,string Error) {}
	///<summary>OnSuccess</summary>
	public FGeoTrackingAvailabilityDelegate OnSuccess;
	///<summary>OnFailed</summary>
	public FGeoTrackingAvailabilityDelegate OnFailed;
	///<summary>Check Geo tracking availability at the user&#39;s current location.</summary>
	public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailability(UObject WorldContextObject) { return default; }
	///<summary>Check Geo tracking availability at a specific Geo location.</summary>
	public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailabilityAtLocation(UObject WorldContextObject,float Longitude,float Latitude) { return default; }
}
