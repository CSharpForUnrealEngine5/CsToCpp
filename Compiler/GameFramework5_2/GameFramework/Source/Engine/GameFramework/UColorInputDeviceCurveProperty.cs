#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>A property that can be used to change the color of an input device's light over time with a curve</summary>
public partial class UColorInputDeviceCurveProperty : UInputDeviceProperty {
// ColorInputDeviceCurveProperty
	public FDeviceColorCurveData ColorData;
	public TMap<string,FDeviceColorCurveData> DeviceOverrideData;
}
