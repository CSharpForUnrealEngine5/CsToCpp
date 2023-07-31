#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Genlock using PTP time from a rivermax card</summary>
[CppInclude("RivermaxCustomTimeStep.h")]
public partial class URivermaxCustomTimeStep : UGenlockedCustomTimeStep {
	///<summary>Target frame rate to which to genlock. Uses ST2059 standard to align PTP time to standard genlock</summary>
	public FFrameRate FrameRate;
	///<summary>When enabled, will warn for skipped frames when engine is too slow</summary>
	public bool bEnableOverrunDetection;
	///<summary>Engine used to initialize the Provider</summary>
	public UEngine InitializedEngine;
}
