namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>JumpForce moves the target in a jump-like manner (ends when landing, applied force is relative)</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource_JumpForce {
	public FRotator Rotation;
	public float Distance;
	public float Height;
	public bool bDisableTimeout;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
}
