namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A predefined force-feedback effect to be played on a controller</summary>
[CppInclude("GameFramework/ForceFeedbackEffect.h")]
public partial class UForceFeedbackEffect : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ChannelDetails</summary>
	public TArray<FForceFeedbackChannelDetails> ChannelDetails;
	///<summary>A map of platform name -&gt; ForceFeedback channel details</summary>
	public TMap<FName,FForceFeedbackEffectOverridenChannelDetails> PerDeviceOverrides;
	///<summary>A map of input device properties that we want to set while this effect is playing</summary>
	public TArray<UInputDeviceProperty> DeviceProperties;
	///<summary>Duration of force feedback pattern in seconds.</summary>
	public float Duration;
}
