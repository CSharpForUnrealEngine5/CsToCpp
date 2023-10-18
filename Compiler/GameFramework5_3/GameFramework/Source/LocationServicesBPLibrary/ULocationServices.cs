namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
public partial class ULocationServices : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Called to set up the Location Service before use</summary>
	public static bool InitLocationServices(ELocationAccuracy Accuracy,float UpdateFrequency,float MinDistanceFilter) { return default; }
	///<summary>Starts requesting location updates from the appropriate Location Service</summary>
	public static bool StartLocationServices() { return default; }
	///<summary>Stops the updates of location from the Location Service that was started with StartLocationService</summary>
	public static bool StopLocationServices() { return default; }
	///<summary>Returns the last location information returned by the location service. If no location update has been made, will return</summary>
	public static FLocationServicesData GetLastKnownLocation() { return default; }
	///<summary>Checks if the Location Services on the mobile device are enabled for this application</summary>
	public static bool AreLocationServicesEnabled() { return default; }
	///<summary>Checks if the supplied Accuracy is available on the current device.</summary>
	public static bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy) { return default; }
	///<summary>* Returns the Location Services implementation object. Intended to be used to set up the FLocationServicesData_OnLocationChanged</summary>
	public static ULocationServicesImpl GetLocationServicesImpl() { return default; }
}
