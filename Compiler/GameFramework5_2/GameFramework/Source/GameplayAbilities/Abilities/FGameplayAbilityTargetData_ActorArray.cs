#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
///<summary>Target data with a source location and a list of targeted actors, makes sense for AOE attacks</summary>
public partial struct FGameplayAbilityTargetData_ActorArray {
// GameplayAbilityTargetData_ActorArray
	public FGameplayAbilityTargetingLocationInfo SourceLocation;
	public TArray<TWeakObjectPtr<AActor>> TargetActorArray;
}
