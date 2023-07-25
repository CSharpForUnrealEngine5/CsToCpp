#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_WaitOverlap.h")]
///<summary>Fixme: this is still incomplete and probablyh not what most games want for melee systems.</summary>
public partial class UAbilityTask_WaitOverlap : UAbilityTask {
// AbilityTask_WaitOverlap
	public FWaitOverlapDelegate OnOverlap;
	public void OnHitCallback(UObject HitComp,UObject OtherActor,UObject OtherComp,FVector NormalImpulse,FHitResult Hit) {}
	public UObject WaitForOverlap(UObject OwningAbility) { return default; }
}
