namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MoveToDynamicForce moves the target to a given location in world space over the duration, where the end location</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource_MoveToDynamicForce {
	public FVector StartLocation;
	public FVector InitialTargetLocation;
	public FVector TargetLocation;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
	public UCurveFloat TimeMappingCurve;
}
