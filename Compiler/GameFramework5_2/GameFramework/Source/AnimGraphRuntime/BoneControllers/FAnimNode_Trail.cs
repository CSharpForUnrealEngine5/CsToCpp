#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Trail Controller</summary>
[CppInclude("BoneControllers/AnimNode_Trail.h")]
public partial struct FAnimNode_Trail {
	public FBoneReference TrailBone;
	public int ChainLength;
	public EAxis ChainBoneAxis;
	public bool bInvertChainBoneAxis;
	public bool bLimitStretch;
	public bool bLimitRotation;
	public bool bUsePlanarLimit;
	public bool bActorSpaceFakeVel;
	public bool bReorientParentToChild;
	public bool bEnableDebug;
	public bool bShowBaseMotion;
	public bool bShowTrailLocation;
	public bool bShowLimit;
	public float DebugLifeTime;
	public float TrailRelaxation_DEPRECATED;
	public float MaxDeltaTime;
	public float RelaxationSpeedScale;
	public FRuntimeFloatCurve TrailRelaxationSpeed;
	public FInputScaleBiasClamp RelaxationSpeedScaleInputProcessor;
	public TArray<FRotationLimit> RotationLimits;
	public TArray<FVector> RotationOffsets;
	public TArray<FAnimPhysPlanarLimit> PlanarLimits;
	public float StretchLimit;
	public FVector FakeVelocity;
	public FBoneReference BaseJoint;
	public float TrailBoneRotationBlendAlpha_DEPRECATED;
	public float LastBoneRotationAnimAlphaBlend;
}
