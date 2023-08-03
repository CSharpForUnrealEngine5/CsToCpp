#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets trigger vibration</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceTriggerVibrationProperty : UInputDeviceTriggerEffect {
	public static UClass StaticClass() {return default;}
	///<summary>TriggerData</summary>
	public FDeviceTriggerTriggerVibrationData TriggerData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<string,FDeviceTriggerTriggerVibrationData> DeviceOverrideData;
}
