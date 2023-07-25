#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDataTypes.h")]
public partial struct FIKRigGoal {
// IKRigGoal
	public string Name;
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
