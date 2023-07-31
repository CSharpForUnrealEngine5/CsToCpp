#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that determines a Body Modifier used during initialization of the physics control actor</summary>
[CppInclude("PhysicsControlActor.h")]
public partial struct FInitialBodyModifier {
	public AActor Actor;
	public string MeshComponentName;
	public string BoneName;
	public EPhysicsMovementType MovementType;
	public float GravityMultiplier;
	public FVector KinematicTargetPosition;
	public FQuat KinematicTargetOrientation;
	public bool bUseSkeletalAnimation;
}
