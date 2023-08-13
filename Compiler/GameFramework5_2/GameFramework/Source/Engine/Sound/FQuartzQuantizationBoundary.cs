namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>struct used to specify the quantization boundary of an event</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzQuantizationBoundary {
	public EQuartzCommandQuantization Quantization;
	public float Multiplier;
	public EQuarztQuantizationReference CountingReferencePoint;
	public bool bFireOnClockStart;
	public bool bCancelCommandIfClockIsNotRunning;
	public bool bResetClockOnQueued;
	public bool bResumeClockOnQueued;
}
