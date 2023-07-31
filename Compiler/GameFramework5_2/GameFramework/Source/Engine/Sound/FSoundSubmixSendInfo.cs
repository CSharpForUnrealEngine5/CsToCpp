#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used to send audio to submixes from USoundBase</summary>
[CppInclude("Sound/SoundSubmixSend.h")]
public partial struct FSoundSubmixSendInfo {
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
