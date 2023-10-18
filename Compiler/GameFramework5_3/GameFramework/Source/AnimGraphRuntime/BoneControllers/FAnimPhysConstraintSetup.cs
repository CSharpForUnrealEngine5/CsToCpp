namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Constraint setup struct, holds data required to build a physics constraint</summary>
[CppInclude("BoneControllers/AnimNode_AnimDynamics.h")]
public partial struct FAnimPhysConstraintSetup {
	public AnimPhysLinearConstraintType LinearXLimitType;
	public AnimPhysLinearConstraintType LinearYLimitType;
	public AnimPhysLinearConstraintType LinearZLimitType;
	public FVector LinearAxesMin;
	public FVector LinearAxesMax;
	public AnimPhysAngularConstraintType AngularConstraintType;
	public AnimPhysTwistAxis TwistAxis;
	public AnimPhysTwistAxis AngularTargetAxis;
	public float ConeAngle;
	public float AngularXAngle_DEPRECATED;
	public float AngularYAngle_DEPRECATED;
	public float AngularZAngle_DEPRECATED;
	public FVector AngularLimitsMin;
	public FVector AngularLimitsMax;
	public FVector AngularTarget;
}
