#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RawInputSettings.h")]
public partial struct FRawInputDeviceConfiguration {
// RawInputDeviceConfiguration
	public string VendorID;
	public string ProductID;
	public TArray<FRawInputDeviceAxisProperties> AxisProperties;
	public TArray<FRawInputDeviceButtonProperties> ButtonProperties;
}
