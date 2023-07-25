#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPTimecodeCustomTimeStep.h")]
///<summary>Control the engine's time step via the engine's TimecodeProvider.</summary>
public partial class UVPTimecodeCustomTimeStep : UFixedFrameRateCustomTimeStep {
// VPTimecodeCustomTimeStep
	public bool bErrorIfFrameAreNotConsecutive;
	public bool bErrorIfTimecodeProviderChanged;
	public float MaxDeltaTime;
}
