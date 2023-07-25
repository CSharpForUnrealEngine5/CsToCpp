#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmixSend.h")]
///<summary>Class used to send audio to submixes from USoundBase</summary>
public partial struct FSoundSubmixSendInfo {
// SoundSubmixSendInfo
	public ESendLevelControlMethod SendLevelControlMethod;
	public ESubmixSendStage SendStage;
	public USoundSubmixBase SoundSubmix;
	public float SendLevel;
	public bool DisableManualSendClamp;
	public float MinSendLevel;
	public float MaxSendLevel;
	public float MinSendDistance;
	public float MaxSendDistance;
	public FRuntimeFloatCurve CustomSendLevelCurve;
}
