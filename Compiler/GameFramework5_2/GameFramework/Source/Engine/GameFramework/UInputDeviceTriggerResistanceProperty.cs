#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides linear resistance to a trigger while it is being pressed between a start and end value</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect {
	///<summary>TriggerData</summary>
	public FDeviceTriggerTriggerResistanceData TriggerData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<string,FDeviceTriggerTriggerResistanceData> DeviceOverrideData;
}
