#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ArchVisCharMovementComponent.h")]
public partial class UArchVisCharMovementComponent : UCharacterMovementComponent {
	///<summary>Controls how fast the character&#39;s turn rate accelerates when rotating and looking up/down</summary>
	public FRotator RotationalAcceleration;
	///<summary>Controls how fast the character&#39;s turn rate decelerates to 0 when user stops turning</summary>
	public FRotator RotationalDeceleration;
	///<summary>Fastest possible turn rate</summary>
	public FRotator MaxRotationalVelocity;
	///<summary>Controls how far down you can look</summary>
	public float MinPitch;
	///<summary>Controls how far up you can look</summary>
	public float MaxPitch;
	///<summary>Controls walking deceleration.</summary>
	public float WalkingFriction;
	///<summary>How fast the character can walk.</summary>
	public float WalkingSpeed;
	///<summary>How fast the character accelerates.</summary>
	public float WalkingAcceleration;
}
