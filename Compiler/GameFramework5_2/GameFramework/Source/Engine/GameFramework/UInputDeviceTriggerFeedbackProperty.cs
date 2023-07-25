#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>Sets simple trigger feedback</summary>
public partial class UInputDeviceTriggerFeedbackProperty : UInputDeviceTriggerEffect {
// InputDeviceTriggerFeedbackProperty
	public FDeviceTriggerFeedbackData TriggerData;
	public TMap<string,FDeviceTriggerFeedbackData> DeviceOverrideData;
}
