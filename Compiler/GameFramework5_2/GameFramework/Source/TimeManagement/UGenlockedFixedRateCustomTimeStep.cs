#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the Engine TimeStep via a fixed frame rate.</summary>
[CppInclude("GenlockedFixedRateCustomTimeStep.h")]
public partial class UGenlockedFixedRateCustomTimeStep : UGenlockedCustomTimeStep {
	public static UClass StaticClass() {return default;}
	///<summary>Desired frame rate</summary>
	public FFrameRate FrameRate;
	///<summary>Indicates that this custom time step should block to enforce the specified frame rate. Set to false if this is enforced elsewhere.</summary>
	public bool bShouldBlock;
	///<summary>When true, delta time will always be 1/FrameRate, regardless of how much real time has elapsed</summary>
	public bool bForceSingleFrameDeltaTime;
}
