#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveFoliageActor.h")]
public partial class AInteractiveFoliageActor : AStaticMeshActor {
	///<summary>Collision cylinder</summary>
	public UCapsuleComponent CapsuleComponent;
	///<summary>Position of the last actor to enter the collision cylinder.</summary>
	public FVector TouchingActorEntryPosition;
	///<summary>Simulated physics state</summary>
	public FVector FoliageVelocity;
	///<summary>@todo document</summary>
	public FVector FoliageForce;
	///<summary>@todo document</summary>
	public FVector FoliagePosition;
	///<summary>Scales forces applied from damage events.</summary>
	public float FoliageDamageImpulseScale;
	///<summary>Scales forces applied from touch events.</summary>
	public float FoliageTouchImpulseScale;
	///<summary>Determines how strong the force that pushes toward the spring&#39;s center will be.</summary>
	public float FoliageStiffness;
	///<summary>Same as FoliageStiffness, but the strength of this force increases with the square of the distance to the spring&#39;s center.</summary>
	public float FoliageStiffnessQuadratic;
	///<summary>Determines the amount of energy lost by the spring as it oscillates.</summary>
	public float FoliageDamping;
	///<summary>Clamps the magnitude of each damage force applied.</summary>
	public float MaxDamageImpulse;
	///<summary>Clamps the magnitude of each touch force applied.</summary>
	public float MaxTouchImpulse;
	///<summary>Clamps the magnitude of combined forces applied each update.</summary>
	public float MaxForce;
	///<summary>@todo - hook this up     @todo document</summary>
	public float Mass;
	///<summary>Called when capsule is touched</summary>
	public  void CapsuleTouched(UPrimitiveComponent OverlappedComp,AActor Other,UPrimitiveComponent OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult OverlapInfo) {}
}
