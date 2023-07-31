#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Target data with a source location and a list of targeted actors, makes sense for AOE attacks</summary>
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
public partial struct FGameplayAbilityTargetData_ActorArray {
	public FGameplayAbilityTargetingLocationInfo SourceLocation;
	public TArray<TWeakObjectPtr<AActor>> TargetActorArray;
}
