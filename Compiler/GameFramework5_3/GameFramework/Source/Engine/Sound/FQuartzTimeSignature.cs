namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Quartz Time Signature</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzTimeSignature {
	public int NumBeats;
	public EQuartzTimeSignatureQuantization BeatType;
	public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride;
}
