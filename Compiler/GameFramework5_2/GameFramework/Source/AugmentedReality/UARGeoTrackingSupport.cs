#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interface class for Geo tracking related features.</summary>
[CppInclude("ARGeoTrackingSupport.h")]
public partial class UARGeoTrackingSupport : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@return the interface object to support Geo tracking, return null on platforms don&#39;t support the feature.</summary>
	public static UARGeoTrackingSupport GetGeoTrackingSupport() { return default; }
	///<summary>@return the current session&#39;s Geo tracking state.</summary>
	public  EARGeoTrackingState GetGeoTrackingState() { return default; }
	///<summary>@return the current session&#39;s Geo tracking state reason.</summary>
	public  EARGeoTrackingStateReason GetGeoTrackingStateReason() { return default; }
	///<summary>@return the current session&#39;s Geo tracking state accuracy.</summary>
	public  EARGeoTrackingAccuracy GetGeoTrackingAccuracy() { return default; }
	///<summary>@return add an Geo anchor at a specific location.</summary>
	public  bool AddGeoAnchorAtLocation(float Longitude,float Latitude,string OptionalAnchorName) { return default; }
	///<summary>@return add an Geo anchor at a specific location with an altitude (in meters).</summary>
	public  bool AddGeoAnchorAtLocationWithAltitude(float Longitude,float Latitude,float AltitudeMeters,string OptionalAnchorName) { return default; }
}
