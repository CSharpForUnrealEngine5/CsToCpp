namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioImpulseResponse</summary>
[CppInclude("EffectConvolutionReverb.h")]
public partial class UAudioImpulseResponse : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The interleaved audio samples used in convolution.</summary>
	public TArray<float> ImpulseResponse;
	///<summary>The number of channels in impulse response.</summary>
	public int NumChannels;
	///<summary>The original sample rate of the impulse response.</summary>
	public int SampleRate;
	///<summary>Used to account for energy added by convolution with &quot;loud&quot; Impulse Responses.</summary>
	public float NormalizationVolumeDb;
	///<summary>If true, impulse response channels are interpreted as true stereo which allows channel crosstalk. If false, impulse response channels are interpreted as independent channel impulses.</summary>
	public bool bTrueStereo;
	///<summary>IRData_DEPRECATED</summary>
	public TArray<float> IRData_DEPRECATED;
	///<summary>Used to evaluate whether TrueStereo should be editable</summary>
	public bool bIsEvenChannelCount;
}
