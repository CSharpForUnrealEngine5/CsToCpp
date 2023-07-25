#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AjaCustomTimeStep.h")]
///<summary>Control the Engine TimeStep via the AJA card.</summary>
public partial class UAjaCustomTimeStep : UGenlockedCustomTimeStep {
// AjaCustomTimeStep
	public bool bUseReferenceIn;
	public FMediaIOConfiguration MediaConfiguration;
	public bool bWaitForFrameToBeReady;
	public EMediaIOTimecodeFormat TimecodeFormat;
	public bool bEnableOverrunDetection;
	public UEngine InitializedEngine;
}
