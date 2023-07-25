#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARGeoTrackingSupport.h")]
///<summary>Interface class for Geo tracking related features.</summary>
public partial class UARGeoTrackingSupport : UObject {
// ARGeoTrackingSupport
	public UObject GetGeoTrackingSupport() { return default; }
	public EARGeoTrackingState GetGeoTrackingState() { return default; }
	public EARGeoTrackingStateReason GetGeoTrackingStateReason() { return default; }
	public EARGeoTrackingAccuracy GetGeoTrackingAccuracy() { return default; }
	public bool AddGeoAnchorAtLocation(float Longitude,float Latitude,string OptionalAnchorName) { return default; }
	public bool AddGeoAnchorAtLocationWithAltitude(float Longitude,float Latitude,float AltitudeMeters,string OptionalAnchorName) { return default; }
}
