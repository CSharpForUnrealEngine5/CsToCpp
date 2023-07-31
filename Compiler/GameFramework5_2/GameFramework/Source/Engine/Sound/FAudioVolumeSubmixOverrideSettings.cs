#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioVolume.h")]
public partial struct FAudioVolumeSubmixOverrideSettings {
	public USoundSubmix Submix;
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	public float CrossfadeTime;
}
