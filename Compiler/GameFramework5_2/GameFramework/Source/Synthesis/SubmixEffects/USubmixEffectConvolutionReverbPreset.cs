#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectConvolutionReverb.h")]
public partial class USubmixEffectConvolutionReverbPreset : USoundEffectSubmixPreset {
// SubmixEffectConvolutionReverbPreset
	public void SetSettings(FSubmixEffectConvolutionReverbSettings InSettings) {}
	public void SetImpulseResponse(UObject InImpulseResponse) {}
	public UAudioImpulseResponse ImpulseResponse;
	public FSubmixEffectConvolutionReverbSettings Settings;
	public ESubmixEffectConvolutionReverbBlockSize BlockSize;
	public bool bEnableHardwareAcceleration;
}
