namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubmixEffects/SubmixEffectMultiBandCompressor.h")]
public partial struct FDynamicsBandSettings {
	public float CrossoverTopFrequency;
	public float AttackTimeMsec;
	public float ReleaseTimeMsec;
	public float ThresholdDb;
	public float Ratio;
	public float KneeBandwidthDb;
	public float InputGainDb;
	public float OutputGainDb;
}
