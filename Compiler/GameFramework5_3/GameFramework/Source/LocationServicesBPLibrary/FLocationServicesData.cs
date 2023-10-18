namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to hold relevant location data retrieved from the mobile implementation&#39;s Location Service</summary>
[CppInclude("LocationServicesBPLibrary.h")]
public partial struct FLocationServicesData {
	public float Timestamp;
	public float Longitude;
	public float Latitude;
	public float HorizontalAccuracy;
	public float VerticalAccuracy;
	public float Altitude;
}
