#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSourceBusSend.h")]
public partial struct FSoundSourceBusSendInfo {
	public ESourceBusSendLevelControlMethod SourceBusSendLevelControlMethod;
	public USoundSourceBus SoundSourceBus;
	public UAudioBus AudioBus;
	public float SendLevel;
	public float MinSendLevel;
	public float MaxSendLevel;
	public float MinSendDistance;
	public float MaxSendDistance;
	public FRuntimeFloatCurve CustomSendLevelCurve;
}
