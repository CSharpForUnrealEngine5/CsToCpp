namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that stores a location in one of several different formats</summary>
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
public partial struct FGameplayAbilityTargetingLocationInfo {
	public EGameplayAbilityTargetingLocationType LocationType;
	public FTransform LiteralTransform;
	public AActor SourceActor;
	public UMeshComponent SourceComponent;
	public UGameplayAbility SourceAbility;
	public string SourceSocketName;
}
