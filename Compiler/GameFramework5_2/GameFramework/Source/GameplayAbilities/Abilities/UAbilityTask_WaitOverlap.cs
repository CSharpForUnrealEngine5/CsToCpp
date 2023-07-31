#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fixme: this is still incomplete and probablyh not what most games want for melee systems.</summary>
[CppInclude("Abilities/Tasks/AbilityTask_WaitOverlap.h")]
public partial class UAbilityTask_WaitOverlap : UAbilityTask {
	///<summary>OnOverlap</summary>
	public FWaitOverlapDelegate OnOverlap;
	///<summary>OnHitCallback</summary>
	public  void OnHitCallback(UPrimitiveComponent HitComp,AActor OtherActor,UPrimitiveComponent OtherComp,FVector NormalImpulse,FHitResult Hit) {}
	///<summary>Wait until an overlap occurs. This will need to be better fleshed out so we can specify game specific collision requirements</summary>
	public static UAbilityTask_WaitOverlap WaitForOverlap(UGameplayAbility OwningAbility) { return default; }
}
