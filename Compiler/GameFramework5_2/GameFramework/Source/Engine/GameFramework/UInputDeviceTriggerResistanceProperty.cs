#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>Provides linear resistance to a trigger while it is being pressed between a start and end value</summary>
public partial class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect {
// InputDeviceTriggerResistanceProperty
	public FDeviceTriggerTriggerResistanceData TriggerData;
	public TMap<string,FDeviceTriggerTriggerResistanceData> DeviceOverrideData;
}
