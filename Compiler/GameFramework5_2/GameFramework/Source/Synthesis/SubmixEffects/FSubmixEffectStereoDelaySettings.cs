namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectStereoDelay.h")]
public partial struct FSubmixEffectStereoDelaySettings {
	public EStereoDelaySourceEffect DelayMode;
	public float DelayTimeMsec;
	public float Feedback;
	public float DelayRatio;
	public float WetLevel;
	public float DryLevel;
	public bool bFilterEnabled;
	public EStereoDelayFiltertype FilterType;
	public float FilterFrequency;
	public float FilterQ;
}
