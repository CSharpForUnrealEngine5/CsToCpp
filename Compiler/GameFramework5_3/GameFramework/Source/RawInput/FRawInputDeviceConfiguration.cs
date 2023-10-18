namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RawInputSettings.h")]
public partial struct FRawInputDeviceConfiguration {
	public string VendorID;
	public string ProductID;
	public TArray<FRawInputDeviceAxisProperties> AxisProperties;
	public TArray<FRawInputDeviceButtonProperties> ButtonProperties;
}
