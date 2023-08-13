namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example motion trajectory component implementation for encapsulating: Character Movement ground locomotion</summary>
[CppInclude("MotionTrajectoryCharacterMovement.h")]
public partial class UCharacterMovementTrajectoryComponent : UMotionTrajectoryComponent {
	public static UClass StaticClass() {return default;}
	///<summary>End UMotionTrajectoryComponent Interface</summary>
	public void OnMovementUpdated(float DeltaSeconds,FVector OldLocation,FVector OldVelocity) {}
	///<summary>LastDesiredControlRotation</summary>
	public FRotator LastDesiredControlRotation;
	///<summary>DesiredControlRotationVelocity</summary>
	public FRotator DesiredControlRotationVelocity;
}
