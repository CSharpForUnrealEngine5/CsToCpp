namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A property that can be used to change the color of an input device&#39;s light over time with a curve</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UColorInputDeviceCurveProperty : UInputDeviceProperty {
	public static UClass StaticClass() {return default;}
	///<summary>Default color data that will be used by default. Device Specific overrides will be used when the current input device matches</summary>
	public FDeviceColorCurveData ColorData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<FName,FDeviceColorCurveData> DeviceOverrideData;
}
