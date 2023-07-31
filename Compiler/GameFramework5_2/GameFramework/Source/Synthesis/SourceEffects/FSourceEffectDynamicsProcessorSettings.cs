#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceEffects/SourceEffectDynamicsProcessor.h")]
public partial struct FSourceEffectDynamicsProcessorSettings {
	public ESourceEffectDynamicsProcessorType DynamicsProcessorType;
	public ESourceEffectDynamicsPeakMode PeakMode;
	public float LookAheadMsec;
	public float AttackTimeMsec;
	public float ReleaseTimeMsec;
	public float ThresholdDb;
	public float Ratio;
	public float KneeBandwidthDb;
	public float InputGainDb;
	public float OutputGainDb;
	public bool bStereoLinked;
	public bool bAnalogMode;
}
