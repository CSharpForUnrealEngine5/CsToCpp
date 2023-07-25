#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RivermaxCustomTimeStep.h")]
///<summary>Genlock using PTP time from a rivermax card</summary>
public partial class URivermaxCustomTimeStep : UGenlockedCustomTimeStep {
// RivermaxCustomTimeStep
	public FFrameRate FrameRate;
	public bool bEnableOverrunDetection;
	public UEngine InitializedEngine;
}
