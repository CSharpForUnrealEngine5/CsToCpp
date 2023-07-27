#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrajectoryCharacterMovement.h")]
///<summary>Example motion trajectory component implementation for encapsulating: Character Movement ground locomotion</summary>
public partial class UCharacterMovementTrajectoryComponent : UMotionTrajectoryComponent {
// CharacterMovementTrajectoryComponent
	public  void OnMovementUpdated(float DeltaSeconds,FVector OldLocation,FVector OldVelocity) {}
	public FRotator LastDesiredControlRotation;
	public FRotator DesiredControlRotationVelocity;
}
