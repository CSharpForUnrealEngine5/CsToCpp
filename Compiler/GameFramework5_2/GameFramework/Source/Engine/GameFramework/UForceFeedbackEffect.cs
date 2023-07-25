#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/ForceFeedbackEffect.h")]
///<summary>A predefined force-feedback effect to be played on a controller</summary>
public partial class UForceFeedbackEffect : UObject {
// ForceFeedbackEffect
	public TArray<FForceFeedbackChannelDetails> ChannelDetails;
	public TMap<string,FForceFeedbackEffectOverridenChannelDetails> PerDeviceOverrides;
	public TArray<UInputDeviceProperty> DeviceProperties;
	public float Duration;
}
