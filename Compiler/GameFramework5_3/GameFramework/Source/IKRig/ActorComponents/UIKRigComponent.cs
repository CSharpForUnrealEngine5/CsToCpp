namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorComponents/IKRigComponent.h")]
public partial class UIKRigComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Set an IK Rig Goal position and rotation (assumed in Component Space of Skeletal Mesh) with separate alpha values.</summary>
	public void SetIKRigGoalPositionAndRotation(FName GoalName,FVector Position,FQuat Rotation,float PositionAlpha,float RotationAlpha) {}
	///<summary>Set an IK Rig Goal transform (assumed in Component Space of Skeletal Mesh) with separate alpha values.</summary>
	public void SetIKRigGoalTransform(FName GoalName,FTransform Transform,float PositionAlpha,float RotationAlpha) {}
	///<summary>Apply a IKRigGoal and store it on this rig. Goal transform assumed in Component Space of Skeletal Mesh.</summary>
	public void SetIKRigGoal(FIKRigGoal Goal) {}
	///<summary>Remove all stored goals in this component.</summary>
	public void ClearAllGoals() {}
}
