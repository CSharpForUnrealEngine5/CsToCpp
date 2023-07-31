#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple actor target filter, games can subclass this</summary>
[CppInclude("Abilities/GameplayAbilityTargetDataFilter.h")]
public partial struct FGameplayTargetDataFilter {
	public AActor SelfActor;
	public UClass RequiredActorClass;
	public ETargetDataFilterSelf SelfFilter;
	public bool bReverseFilter;
}
