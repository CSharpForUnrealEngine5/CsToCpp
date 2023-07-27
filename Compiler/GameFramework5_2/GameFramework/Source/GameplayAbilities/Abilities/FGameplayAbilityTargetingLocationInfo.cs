#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
///<summary>Structure that stores a location in one of several different formats</summary>
public partial struct FGameplayAbilityTargetingLocationInfo {
// GameplayAbilityTargetingLocationInfo
	public EGameplayAbilityTargetingLocationType LocationType;
	public FTransform LiteralTransform;
	public AActor SourceActor;
	public UMeshComponent SourceComponent;
	public UGameplayAbility SourceAbility;
	public string SourceSocketName;
}
