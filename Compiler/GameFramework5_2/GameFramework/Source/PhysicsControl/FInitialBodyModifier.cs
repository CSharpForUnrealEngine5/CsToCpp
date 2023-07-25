#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
///<summary>Structure that determines a Body Modifier used during initialization of the physics control actor</summary>
public partial struct FInitialBodyModifier {
// InitialBodyModifier
	public AActor Actor;
	public string MeshComponentName;
	public string BoneName;
	public EPhysicsMovementType MovementType;
	public float GravityMultiplier;
	public FVector KinematicTargetPosition;
	public FQuat KinematicTargetOrientation;
	public bool bUseSkeletalAnimation;
}
