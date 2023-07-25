#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectDefinition.h")]
///<summary>SmartObject definition asset. Contains sharable information that can be used by multiple SmartObject instances at runtime.</summary>
public partial class USmartObjectDefinition : UDataAsset {
// SmartObjectDefinition
	public TSoftObjectPtr<UClass> PreviewClass;
	public FSoftObjectPath PreviewMeshPath;
	public TArray<FSmartObjectSlotDefinition> Slots;
	public TArray<USmartObjectBehaviorDefinition> DefaultBehaviorDefinitions;
	public FGameplayTagQuery UserTagFilter;
	public FGameplayTagQuery ObjectTagFilter;
	public FWorldConditionQueryDefinition Preconditions;
	public FGameplayTagContainer ActivityTags;
	public UClass WorldConditionSchemaClass;
	public ESmartObjectTagMergingPolicy ActivityTagsMergingPolicy;
	public ESmartObjectTagFilteringPolicy UserTagsFilteringPolicy;
}
