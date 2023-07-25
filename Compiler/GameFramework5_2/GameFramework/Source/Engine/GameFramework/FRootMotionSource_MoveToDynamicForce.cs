#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>MoveToDynamicForce moves the target to a given location in world space over the duration, where the end location</summary>
public partial struct FRootMotionSource_MoveToDynamicForce {
// RootMotionSource_MoveToDynamicForce
	public FVector StartLocation;
	public FVector InitialTargetLocation;
	public FVector TargetLocation;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
}
