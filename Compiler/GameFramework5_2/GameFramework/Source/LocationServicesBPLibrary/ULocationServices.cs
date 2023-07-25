#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
public partial class ULocationServices : UBlueprintFunctionLibrary {
// LocationServices
	public bool InitLocationServices(ELocationAccuracy Accuracy,float UpdateFrequency,float MinDistanceFilter) { return default; }
	public bool StartLocationServices() { return default; }
	public bool StopLocationServices() { return default; }
	public FLocationServicesData GetLastKnownLocation() { return default; }
	public bool AreLocationServicesEnabled() { return default; }
	public bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy) { return default; }
	public UObject GetLocationServicesImpl() { return default; }
}
