namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows the user to specify non-uniform beat durations in odd meters</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzPulseOverrideStep {
	public int NumberOfPulses;
	public EQuartzCommandQuantization PulseDuration;
}
