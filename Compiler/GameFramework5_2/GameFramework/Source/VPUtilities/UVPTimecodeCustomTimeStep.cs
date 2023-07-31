#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the engine&#39;s time step via the engine&#39;s TimecodeProvider.</summary>
[CppInclude("VPTimecodeCustomTimeStep.h")]
public partial class UVPTimecodeCustomTimeStep : UFixedFrameRateCustomTimeStep {
	///<summary>If true, stop the CustomTimeStep if the new timecode value doesn&#39;t follow the previous timecode value.</summary>
	public bool bErrorIfFrameAreNotConsecutive;
	///<summary>If true, stop the CustomTimeStep if the engine&#39;s TimeProvider changed since last frame.</summary>
	public bool bErrorIfTimecodeProviderChanged;
	///<summary>If the timecode doesn&#39;t change after that amount of time, stop the CustomTimeStep.</summary>
	public float MaxDeltaTime;
}
