#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/ReverbSettings.h")]
///<summary>Struct encapsulating settings for reverb effects.</summary>
public partial struct FReverbSettings {
// ReverbSettings
	public bool bApplyReverb;
	public ReverbPreset ReverbType_DEPRECATED;
	public UReverbEffect ReverbEffect;
	public USoundEffectSubmixPreset ReverbPluginEffect;
	public float Volume;
	public float FadeTime;
}
