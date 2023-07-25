#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_VisualizeTargeting.h")]
public partial class UAbilityTask_VisualizeTargeting : UAbilityTask {
// AbilityTask_VisualizeTargeting
	public FVisualizeTargetingDelegate TimeElapsed;
	public UObject VisualizeTargeting(UObject OwningAbility,UClass Class,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	public UObject VisualizeTargetingUsingActor(UObject OwningAbility,UObject TargetActor,string TaskInstanceName,float Duration/*=-1.0f*/) { return default; }
	public bool BeginSpawningActor(UObject OwningAbility,UClass Class,UObject SpawnedActor) { return default; }
	public void FinishSpawningActor(UObject OwningAbility,UObject SpawnedActor) {}
}
