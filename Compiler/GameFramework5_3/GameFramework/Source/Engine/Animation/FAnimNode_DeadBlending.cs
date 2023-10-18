namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dead Blending Node</summary>
[CppInclude("Animation/AnimNode_DeadBlending.h")]
public partial struct FAnimNode_DeadBlending {
	public FPoseLink Source;
	public bool bAlwaysUseDefaultBlendSettings;
	public float DefaultBlendDuration;
	public UBlendProfile DefaultBlendProfile;
	public EAlphaBlendOption DefaultBlendMode;
	public UCurveFloat DefaultCustomBlendCurve;
	public float BlendTimeMultiplier;
	public bool bLinearlyInterpolateScales;
	public TArray<FName> FilteredCurves;
	public TArray<FBoneReference> FilteredBones;
	public float ExtrapolationHalfLife;
	public float ExtrapolationHalfLifeMin;
	public float ExtrapolationHalfLifeMax;
	public float MaximumTranslationVelocity;
	public float MaximumRotationVelocity;
	public float MaximumScaleVelocity;
	public float MaximumCurveVelocity;
	public bool bPreallocateMemory;
	public bool bShowExtrapolations;
	public TArray<FInertializationRequest> RequestQueue;
	public UObject InertializationRequestAnimInstance;
	public UCurveFloat InertializationCustomBlendCurve;
}
