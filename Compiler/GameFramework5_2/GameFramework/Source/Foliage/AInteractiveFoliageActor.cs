#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveFoliageActor.h")]
public partial class AInteractiveFoliageActor : AStaticMeshActor {
// InteractiveFoliageActor
	public UCapsuleComponent CapsuleComponent;
	public FVector TouchingActorEntryPosition;
	public FVector FoliageVelocity;
	public FVector FoliageForce;
	public FVector FoliagePosition;
	public float FoliageDamageImpulseScale;
	public float FoliageTouchImpulseScale;
	public float FoliageStiffness;
	public float FoliageStiffnessQuadratic;
	public float FoliageDamping;
	public float MaxDamageImpulse;
	public float MaxTouchImpulse;
	public float MaxForce;
	public float Mass;
	public void CapsuleTouched(UObject OverlappedComp,UObject Other,UObject OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult OverlapInfo) {}
}
