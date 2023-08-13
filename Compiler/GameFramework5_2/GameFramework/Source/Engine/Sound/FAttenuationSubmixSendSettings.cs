namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundAttenuation.h")]
public partial struct FAttenuationSubmixSendSettings {
	public USoundSubmixBase Submix;
	public ESubmixSendMethod SubmixSendMethod;
	public float SubmixSendLevelMin;
	public float SubmixSendLevelMax;
	public float SubmixSendDistanceMin;
	public float SubmixSendDistanceMax;
	public float ManualSubmixSendLevel;
	public FRuntimeFloatCurve CustomSubmixSendCurve;
}
