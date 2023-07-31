#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replicated data when playing a root motion montage.</summary>
[CppInclude("GameFramework/Character.h")]
public partial struct FRepRootMotionMontage {
	public bool bIsActive;
	public UAnimMontage AnimMontage;
	public float Position;
	public FVector_NetQuantize100 Location;
	public FRotator Rotation;
	public UPrimitiveComponent MovementBase;
	public string MovementBaseBoneName;
	public bool bRelativePosition;
	public bool bRelativeRotation;
	public FRootMotionSourceGroup AuthoritativeRootMotion;
	public FVector_NetQuantize10 Acceleration;
	public FVector_NetQuantize10 LinearVelocity;
}
