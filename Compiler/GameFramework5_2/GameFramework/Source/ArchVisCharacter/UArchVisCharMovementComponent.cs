#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ArchVisCharMovementComponent.h")]
public partial class UArchVisCharMovementComponent : UCharacterMovementComponent {
// ArchVisCharMovementComponent
	public FRotator RotationalAcceleration;
	public FRotator RotationalDeceleration;
	public FRotator MaxRotationalVelocity;
	public float MinPitch;
	public float MaxPitch;
	public float WalkingFriction;
	public float WalkingSpeed;
	public float WalkingAcceleration;
}
