#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DefaultPawn implements a simple Pawn with spherical collision and built-in flying movement.</summary>
[CppInclude("GameFramework/DefaultPawn.h")]
public partial class ADefaultPawn : APawn {
	public static UClass StaticClass() {return default;}
	///<summary>Input callback to move forward in local space (or backward if Val is negative).</summary>
	public  void MoveForward(float Val) {}
	///<summary>Input callback to strafe right in local space (or left if Val is negative).</summary>
	public  void MoveRight(float Val) {}
	///<summary>Input callback to move up in world space (or down if Val is negative).</summary>
	public  void MoveUp_World(float Val) {}
	///<summary>Called via input to turn at a given rate.</summary>
	public  void TurnAtRate(float Rate) {}
	///<summary>Called via input to look up at a given rate (or down if Rate is negative).</summary>
	public  void LookUpAtRate(float Rate) {}
	///<summary>Base turn rate, in deg/sec. Other scaling may affect final turn rate.</summary>
	public float BaseTurnRate;
	///<summary>Base lookup rate, in deg/sec. Other scaling may affect final lookup rate.</summary>
	public float BaseLookUpRate;
	///<summary>DefaultPawn movement component</summary>
	public UPawnMovementComponent MovementComponent;
	///<summary>DefaultPawn collision component</summary>
	public USphereComponent CollisionComponent;
	///<summary>The mesh associated with this Pawn.</summary>
	public UStaticMeshComponent MeshComponent;
	///<summary>If true, adds default input bindings for movement and camera look.</summary>
	public bool bAddDefaultMovementBindings;
}
