namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
public partial struct FAudioVolumeSubmixOverrideSettings {
	public USoundSubmix Submix;
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	public float CrossfadeTime;
}
