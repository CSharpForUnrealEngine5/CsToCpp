#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_StrideWarping.h")]
public partial struct FAnimNode_StrideWarping {
	public EWarpingEvaluationMode Mode;
	public FVector StrideDirection;
	public float StrideScale;
	public float LocomotionSpeed;
	public float MinRootMotionSpeedThreshold;
	public FBoneReference PelvisBone;
	public FBoneReference IKFootRootBone;
	public TArray<FStrideWarpingFootDefinition> FootDefinitions;
	public FInputClampConstants StrideScaleModifier;
	public FWarpingVectorValue FloorNormalDirection;
	public FWarpingVectorValue GravityDirection;
	public FIKFootPelvisPullDownSolver PelvisIKFootSolver;
	public bool bOrientStrideDirectionUsingFloorNormal;
	public bool bCompensateIKUsingFKThighRotation;
	public bool bClampIKUsingFKLimits;
	public float DebugDrawScale;
	public bool bEnableDebugDraw;
	public bool bDebugDrawIKFootOrigin;
	public bool bDebugDrawIKFootAdjustment;
	public bool bDebugDrawPelvisAdjustment;
	public bool bDebugDrawThighAdjustment;
	public bool bDebugDrawIKFootFinal;
}
