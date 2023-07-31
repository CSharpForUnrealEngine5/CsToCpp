#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Quartz Time Signature</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzTimeSignature {
	public int NumBeats;
	public EQuartzTimeSignatureQuantization BeatType;
	public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride;
}
