#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial class UIKRigEffectorGoal : UObject {
// IKRigEffectorGoal
	public string GoalName;
	public string BoneName;
	public float PositionAlpha;
	public float RotationAlpha;
	public FTransform CurrentTransform;
	public FTransform InitialTransform;
	public EIKRigGoalPreviewMode PreviewMode;
	public float SizeMultiplier;
	public float ThicknessMultiplier;
	public bool bExposePosition;
	public bool bExposeRotation;
}
