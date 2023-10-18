namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component tries to maintain its children at a fixed distance from the parent,</summary>
[CppInclude("GameFramework/SpringArmComponent.h")]
public partial class USpringArmComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Natural length of the spring arm when there are no collisions</summary>
	public float TargetArmLength;
	///<summary>offset at end of spring arm; use this instead of the relative offset of the attached component to ensure the line trace works as desired</summary>
	public FVector SocketOffset;
	///<summary>Offset at start of spring, applied in world space. Use this if you want a world-space offset from the parent component instead of the usual relative-space offset.</summary>
	public FVector TargetOffset;
	///<summary>How big should the query probe sphere be (in unreal units)</summary>
	public float ProbeSize;
	///<summary>Collision channel of the query probe (defaults to ECC_Camera)</summary>
	public ECollisionChannel ProbeChannel;
	///<summary>If true, do a collision test using ProbeChannel and ProbeSize to prevent camera clipping into level.</summary>
	public bool bDoCollisionTest;
	///<summary>If this component is placed on a pawn, should it use the view/control rotation of the pawn where possible?</summary>
	public bool bUsePawnControlRotation;
	///<summary>Should we inherit pitch from parent component. Does nothing if using Absolute Rotation.</summary>
	public bool bInheritPitch;
	///<summary>Should we inherit yaw from parent component. Does nothing if using Absolute Rotation.</summary>
	public bool bInheritYaw;
	///<summary>Should we inherit roll from parent component. Does nothing if using Absolute Rotation.</summary>
	public bool bInheritRoll;
	///<summary>If true, camera lags behind target position to smooth its movement.</summary>
	public bool bEnableCameraLag;
	///<summary>If true, camera lags behind target rotation to smooth its movement.</summary>
	public bool bEnableCameraRotationLag;
	///<summary>If bUseCameraLagSubstepping is true, sub-step camera damping so that it handles fluctuating frame rates well (though this comes at a cost).</summary>
	public bool bUseCameraLagSubstepping;
	///<summary>If true and camera location lag is enabled, draws markers at the camera target (in green) and the lagged position (in yellow).</summary>
	public bool bDrawDebugLagMarkers;
	///<summary>If bEnableCameraLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
	public float CameraLagSpeed;
	///<summary>If bEnableCameraRotationLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).</summary>
	public float CameraRotationLagSpeed;
	///<summary>Max time step used when sub-stepping camera lag.</summary>
	public float CameraLagMaxTimeStep;
	///<summary>Max distance the camera target may lag behind the current location. If set to zero, no max distance is enforced.</summary>
	public float CameraLagMaxDistance;
	///<summary>If true AND the view target is simulating using physics then use the same max timestep cap as the physics system. Prevents camera jitter when delta time is clamped within Chaos Physics.</summary>
	public bool bClampToMaxPhysicsDeltaTime;
	///<summary>Get the target rotation we inherit, used as the base target for the boom rotation.</summary>
	public FRotator GetTargetRotation() { return default; }
	///<summary>Get the position where the camera should be without applying the Collision Test displacement</summary>
	public FVector GetUnfixedCameraPosition() { return default; }
	///<summary>Is the Collision Test displacement being applied?</summary>
	public bool IsCollisionFixApplied() { return default; }
}
