#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EffectConvolutionReverb.h")]
///<summary>UAudioImpulseResponse</summary>
public partial class UAudioImpulseResponse : UObject {
// AudioImpulseResponse
	public TArray<float> ImpulseResponse;
	public int NumChannels;
	public int SampleRate;
	public float NormalizationVolumeDb;
	public bool bTrueStereo;
	public TArray<float> IRData_DEPRECATED;
	public bool bIsEvenChannelCount;
}
