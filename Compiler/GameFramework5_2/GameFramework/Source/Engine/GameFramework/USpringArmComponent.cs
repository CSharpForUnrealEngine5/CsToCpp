#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/SpringArmComponent.h")]
///<summary>This component tries to maintain its children at a fixed distance from the parent,</summary>
public partial class USpringArmComponent : USceneComponent {
// SpringArmComponent
	public float TargetArmLength;
	public FVector SocketOffset;
	public FVector TargetOffset;
	public float ProbeSize;
	public ECollisionChannel ProbeChannel;
	public bool bDoCollisionTest;
	public bool bUsePawnControlRotation;
	public bool bInheritPitch;
	public bool bInheritYaw;
	public bool bInheritRoll;
	public bool bEnableCameraLag;
	public bool bEnableCameraRotationLag;
	public bool bUseCameraLagSubstepping;
	public bool bDrawDebugLagMarkers;
	public float CameraLagSpeed;
	public float CameraRotationLagSpeed;
	public float CameraLagMaxTimeStep;
	public float CameraLagMaxDistance;
	public bool bClampToMaxPhysicsDeltaTime;
	public  FRotator GetTargetRotation() { return default; }
	public  FVector GetUnfixedCameraPosition() { return default; }
	public  bool IsCollisionFixApplied() { return default; }
}
