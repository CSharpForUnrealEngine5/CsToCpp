#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
public partial class ULocationServices : UBlueprintFunctionLibrary {
// LocationServices
	public static bool InitLocationServices(ELocationAccuracy Accuracy,float UpdateFrequency,float MinDistanceFilter) { return default; }
	public static bool StartLocationServices() { return default; }
	public static bool StopLocationServices() { return default; }
	public static FLocationServicesData GetLastKnownLocation() { return default; }
	public static bool AreLocationServicesEnabled() { return default; }
	public static bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy) { return default; }
	public static ULocationServicesImpl GetLocationServicesImpl() { return default; }
}
