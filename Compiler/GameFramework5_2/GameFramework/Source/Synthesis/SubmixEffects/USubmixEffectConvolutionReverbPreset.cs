namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectConvolutionReverb.h")]
public partial class USubmixEffectConvolutionReverbPreset : USoundEffectSubmixPreset {
	public static UClass StaticClass() {return default;}
	///<summary>Set the convolution reverb settings</summary>
	public void SetSettings(FSubmixEffectConvolutionReverbSettings InSettings) {}
	///<summary>Set the convolution reverb impulse response</summary>
	public void SetImpulseResponse(UAudioImpulseResponse InImpulseResponse) {}
	///<summary>The impulse response used for convolution.</summary>
	public UAudioImpulseResponse ImpulseResponse;
	///<summary>ConvolutionReverbPreset Preset Settings.</summary>
	public FSubmixEffectConvolutionReverbSettings Settings;
	///<summary>Set the internal block size. This can effect latency and performance. Higher values will result in</summary>
	public ESubmixEffectConvolutionReverbBlockSize BlockSize;
	///<summary>Opt into hardware acceleration of the convolution reverb (if available)</summary>
	public bool bEnableHardwareAcceleration;
}
