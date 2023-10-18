namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct encapsulating settings for reverb effects.</summary>
[CppInclude("Sound/ReverbSettings.h")]
public partial struct FReverbSettings {
	public bool bApplyReverb;
	public ReverbPreset ReverbType_DEPRECATED;
	public UReverbEffect ReverbEffect;
	public USoundEffectSubmixPreset ReverbPluginEffect;
	public float Volume;
	public float FadeTime;
}
