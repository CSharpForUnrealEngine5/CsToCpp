#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorComponents/IKRigComponent.h")]
public partial class UIKRigComponent : UActorComponent {
// IKRigComponent
	public  void SetIKRigGoalPositionAndRotation(string GoalName,FVector Position,FQuat Rotation,float PositionAlpha,float RotationAlpha) {}
	public  void SetIKRigGoalTransform(string GoalName,FTransform Transform,float PositionAlpha,float RotationAlpha) {}
	public  void SetIKRigGoal(FIKRigGoal Goal) {}
	public  void ClearAllGoals() {}
}
