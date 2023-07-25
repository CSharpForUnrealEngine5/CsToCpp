#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/DefaultPawn.h")]
///<summary>DefaultPawn implements a simple Pawn with spherical collision and built-in flying movement.</summary>
public partial class ADefaultPawn : APawn {
// DefaultPawn
	public void MoveForward(float Val) {}
	public void MoveRight(float Val) {}
	public void MoveUp_World(float Val) {}
	public void TurnAtRate(float Rate) {}
	public void LookUpAtRate(float Rate) {}
	public float BaseTurnRate;
	public float BaseLookUpRate;
	public UPawnMovementComponent MovementComponent;
	public USphereComponent CollisionComponent;
	public UStaticMeshComponent MeshComponent;
	public bool bAddDefaultMovementBindings;
}
