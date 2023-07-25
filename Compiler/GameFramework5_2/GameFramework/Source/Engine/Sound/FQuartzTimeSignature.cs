#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>Quartz Time Signature</summary>
public partial struct FQuartzTimeSignature {
// QuartzTimeSignature
	public int NumBeats;
	public EQuartzTimeSignatureQuantization BeatType;
	public TArray<FQuartzPulseOverrideStep> OptionalPulseOverride;
}
