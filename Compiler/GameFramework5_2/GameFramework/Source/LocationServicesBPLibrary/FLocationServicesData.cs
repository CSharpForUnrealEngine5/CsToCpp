#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
///<summary>Struct to hold relevant location data retrieved from the mobile implementation's Location Service</summary>
public partial struct FLocationServicesData {
// LocationServicesData
	public float Timestamp;
	public float Longitude;
	public float Latitude;
	public float HorizontalAccuracy;
	public float VerticalAccuracy;
	public float Altitude;
}
