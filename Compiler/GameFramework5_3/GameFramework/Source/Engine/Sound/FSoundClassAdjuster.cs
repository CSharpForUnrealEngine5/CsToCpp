namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Elements of data for sound group volume control</summary>
[CppInclude("Sound/SoundMix.h")]
public partial struct FSoundClassAdjuster {
	public USoundClass SoundClassObject;
	public float VolumeAdjuster;
	public float PitchAdjuster;
	public float LowPassFilterFrequency;
	public bool bApplyToChildren;
	public float VoiceCenterChannelVolumeAdjuster;
}
