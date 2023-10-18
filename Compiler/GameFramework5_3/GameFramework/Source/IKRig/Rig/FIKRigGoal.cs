namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/IKRigDataTypes.h")]
public partial struct FIKRigGoal {
	public FName Name;
	public EIKRigGoalTransformSource TransformSource;
	public FBoneReference SourceBone;
	public FVector Position;
	public FRotator Rotation;
	public float PositionAlpha;
	public float RotationAlpha;
	public EIKRigGoalSpace PositionSpace;
	public EIKRigGoalSpace RotationSpace;
	public FVector FinalBlendedPosition;
	public FQuat FinalBlendedRotation;
}
