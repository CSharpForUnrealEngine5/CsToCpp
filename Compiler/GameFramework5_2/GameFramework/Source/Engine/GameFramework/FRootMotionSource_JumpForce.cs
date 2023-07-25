#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>JumpForce moves the target in a jump-like manner (ends when landing, applied force is relative)</summary>
public partial struct FRootMotionSource_JumpForce {
// RootMotionSource_JumpForce
	public FRotator Rotation;
	public float Distance;
	public float Height;
	public bool bDisableTimeout;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
}
