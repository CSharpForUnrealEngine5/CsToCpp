#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
public partial struct FAudioVolumeSubmixOverrideSettings {
// AudioVolumeSubmixOverrideSettings
	public USoundSubmix Submix;
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	public float CrossfadeTime;
}
