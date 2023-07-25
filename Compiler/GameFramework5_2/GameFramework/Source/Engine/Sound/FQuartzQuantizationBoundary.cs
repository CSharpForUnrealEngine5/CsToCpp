#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>struct used to specify the quantization boundary of an event</summary>
public partial struct FQuartzQuantizationBoundary {
// QuartzQuantizationBoundary
	public EQuartzCommandQuantization Quantization;
	public float Multiplier;
	public EQuarztQuantizationReference CountingReferencePoint;
	public bool bFireOnClockStart;
	public bool bCancelCommandIfClockIsNotRunning;
	public bool bResetClockOnQueued;
	public bool bResumeClockOnQueued;
}
