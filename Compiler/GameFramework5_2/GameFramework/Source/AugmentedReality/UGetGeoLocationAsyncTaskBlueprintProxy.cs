#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint async task to convert Geo location.</summary>
[CppInclude("ARGeoTrackingSupport.h")]
public partial class UGetGeoLocationAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
	public static UClass StaticClass() {return default;}
	///<summary>FGetGeoLocationDelegate</summary>
	public  void FGetGeoLocationDelegate(float Longitude,float Latitude,float Altitude,string Error) {}
	///<summary>OnSuccess</summary>
	public FGetGeoLocationDelegate OnSuccess;
	///<summary>OnFailed</summary>
	public FGetGeoLocationDelegate OnFailed;
	///<summary>Convert a position in UE4 world space into a Geo location.</summary>
	public static UGetGeoLocationAsyncTaskBlueprintProxy GetGeoLocationAtWorldPosition(UObject WorldContextObject,FVector WorldPosition) { return default; }
}
