#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundMix.h")]
///<summary>Elements of data for sound group volume control</summary>
public partial struct FSoundClassAdjuster {
// SoundClassAdjuster
	public USoundClass SoundClassObject;
	public float VolumeAdjuster;
	public float PitchAdjuster;
	public float LowPassFilterFrequency;
	public bool bApplyToChildren;
	public float VoiceCenterChannelVolumeAdjuster;
}
