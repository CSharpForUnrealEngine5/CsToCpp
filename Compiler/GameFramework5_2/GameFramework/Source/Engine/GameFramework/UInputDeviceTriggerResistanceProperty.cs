namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides linear resistance to a trigger while it is being pressed between a start and end value</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect {
	public static UClass StaticClass() {return default;}
	///<summary>TriggerData</summary>
	public FDeviceTriggerTriggerResistanceData TriggerData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<string,FDeviceTriggerTriggerResistanceData> DeviceOverrideData;
}
