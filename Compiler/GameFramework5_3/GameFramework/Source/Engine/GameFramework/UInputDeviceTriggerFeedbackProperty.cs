namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets simple trigger feedback</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceTriggerFeedbackProperty : UInputDeviceTriggerEffect {
	public static UClass StaticClass() {return default;}
	///<summary>What position on the trigger that the feedback should be applied to over time (1-9)</summary>
	public FDeviceTriggerFeedbackData TriggerData;
	///<summary>A map of device specific color data. If no overrides are specified, the Default hardware data will be used</summary>
	public TMap<FName,FDeviceTriggerFeedbackData> DeviceOverrideData;
}
