#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GenlockedFixedRateCustomTimeStep.h")]
///<summary>Control the Engine TimeStep via a fixed frame rate.</summary>
public partial class UGenlockedFixedRateCustomTimeStep : UGenlockedCustomTimeStep {
// GenlockedFixedRateCustomTimeStep
	public FFrameRate FrameRate;
	public bool bShouldBlock;
	public bool bForceSingleFrameDeltaTime;
}
