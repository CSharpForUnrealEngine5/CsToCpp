#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectConvolutionReverb.h")]
public partial class USourceEffectConvolutionReverbPreset : USoundEffectSourcePreset {
// SourceEffectConvolutionReverbPreset
	public void SetSettings(FSourceEffectConvolutionReverbSettings InSettings) {}
	public void SetImpulseResponse(UObject InImpulseResponse) {}
	public UAudioImpulseResponse ImpulseResponse;
	public FSourceEffectConvolutionReverbSettings Settings;
	public ESubmixEffectConvolutionReverbBlockSize BlockSize;
	public bool bEnableHardwareAcceleration;
}
