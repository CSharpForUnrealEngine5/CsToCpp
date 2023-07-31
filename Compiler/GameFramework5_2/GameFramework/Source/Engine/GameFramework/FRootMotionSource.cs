#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generalized source of Root Motion to a CharacterMovementComponent.</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource {
	public ushort Priority;
	public ushort LocalID;
	public ERootMotionAccumulateMode AccumulateMode;
	public string InstanceName;
	public float StartTime;
	public float CurrentTime;
	public float PreviousTime;
	public float Duration;
	public FRootMotionSourceStatus Status;
	public FRootMotionSourceSettings Settings;
	public bool bInLocalSpace;
	public FRootMotionMovementParams RootMotionParams;
	public FRootMotionFinishVelocitySettings FinishVelocityParams;
}
