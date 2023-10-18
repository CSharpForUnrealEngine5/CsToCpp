namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SmartObject definition asset. Contains sharable information that can be used by multiple SmartObject instances at runtime.</summary>
[CppInclude("SmartObjectDefinition.h")]
public partial class USmartObjectDefinition : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewClass_DEPRECATED</summary>
	public TSoftObjectPtr<UClass> PreviewClass_DEPRECATED;
	///<summary>PreviewMeshPath_DEPRECATED</summary>
	public FSoftObjectPath PreviewMeshPath_DEPRECATED;
	///<summary>Actor class used for previewing the user in the asset editor.</summary>
	public FSmartObjectDefinitionPreviewData PreviewData;
	///<summary>Where SmartObject&#39;s user needs to stay to be able to activate it. These</summary>
	public TArray<FSmartObjectSlotDefinition> Slots;
	///<summary>List of behavior definitions of different types provided to SO&#39;s user if the slot does not provide one.</summary>
	public TArray<USmartObjectBehaviorDefinition> DefaultBehaviorDefinitions;
	///<summary>This object is available if user tags match this query; always available if query is empty.</summary>
	public FGameplayTagQuery UserTagFilter;
	///<summary>ObjectTagFilter</summary>
	public FGameplayTagQuery ObjectTagFilter;
	///<summary>Preconditions that must pass for the object to be found/used.</summary>
	public FWorldConditionQueryDefinition Preconditions;
	///<summary>Tags identifying this Smart Object&#39;s use case. Can be used while looking for objects supporting given activity</summary>
	public FGameplayTagContainer ActivityTags;
	///<summary>WorldConditionSchemaClass</summary>
	public UClass WorldConditionSchemaClass;
	///<summary>Indicates how Tags from slots and parent object are combined to be evaluated by a TagQuery from a find request.</summary>
	public ESmartObjectTagMergingPolicy ActivityTagsMergingPolicy;
	///<summary>Indicates how TagQueries from slots and parent object will be processed against User Tags from a find request.</summary>
	public ESmartObjectTagFilteringPolicy UserTagsFilteringPolicy;
}
