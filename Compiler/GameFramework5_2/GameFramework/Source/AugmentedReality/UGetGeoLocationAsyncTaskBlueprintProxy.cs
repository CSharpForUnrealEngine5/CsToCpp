#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Blueprint async task to convert Geo location.</summary>
public partial class UGetGeoLocationAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
// GetGeoLocationAsyncTaskBlueprintProxy
	public  void FGetGeoLocationDelegate(float Longitude,float Latitude,float Altitude,string Error) {}
	public FGetGeoLocationDelegate OnSuccess;
	public FGetGeoLocationDelegate OnFailed;
	public static UGetGeoLocationAsyncTaskBlueprintProxy GetGeoLocationAtWorldPosition(UObject WorldContextObject,FVector WorldPosition) { return default; }
}
