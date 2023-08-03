#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial class UIKRigEffectorGoal : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name used to refer to this goal from outside systems.</summary>
	public string GoalName;
	///<summary>The name of the bone that this Goal is located at.</summary>
	public string BoneName;
	///<summary>Range 0-1, default is 1. Blend between the input bone position (0.0) and the current goal position (1.0).</summary>
	public float PositionAlpha;
	///<summary>Range 0-1, default is 1. Blend between the input bone rotation (0.0) and the current goal rotation (1.0).</summary>
	public float RotationAlpha;
	///<summary>The current transform of this Goal, in the Global Space of the character.</summary>
	public FTransform CurrentTransform;
	///<summary>The initial transform of this Goal, as defined by the initial transform of the Goal&#39;s bone in the retarget pose.</summary>
	public FTransform InitialTransform;
	///<summary>Effects how this Goal transform is previewed in the IK Rig editor.</summary>
	public EIKRigGoalPreviewMode PreviewMode;
	///<summary>The size of the Goal gizmo drawing in the editor viewport.</summary>
	public float SizeMultiplier;
	///<summary>The thickness of the Goal gizmo drawing in the editor viewport.</summary>
	public float ThicknessMultiplier;
	///<summary>Should position data be exposed in Blueprint</summary>
	public bool bExposePosition;
	///<summary>Should rotation data be exposed in Blueprint</summary>
	public bool bExposeRotation;
}
