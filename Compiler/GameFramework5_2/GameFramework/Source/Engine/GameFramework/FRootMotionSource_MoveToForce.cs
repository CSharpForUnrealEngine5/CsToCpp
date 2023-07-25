#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>MoveToForce moves the target to a given fixed location in world space over the duration</summary>
public partial struct FRootMotionSource_MoveToForce {
// RootMotionSource_MoveToForce
	public FVector StartLocation;
	public FVector TargetLocation;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
}
