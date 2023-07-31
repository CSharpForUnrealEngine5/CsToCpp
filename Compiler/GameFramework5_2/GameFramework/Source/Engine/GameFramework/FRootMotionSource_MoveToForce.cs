#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MoveToForce moves the target to a given fixed location in world space over the duration</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource_MoveToForce {
	public FVector StartLocation;
	public FVector TargetLocation;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
}
