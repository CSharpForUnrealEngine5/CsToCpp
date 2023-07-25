#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetDataFilter.h")]
///<summary>Simple actor target filter, games can subclass this</summary>
public partial struct FGameplayTargetDataFilter {
// GameplayTargetDataFilter
	public AActor SelfActor;
	public UClass RequiredActorClass;
	public byte SelfFilter;
	public bool bReverseFilter;
}
