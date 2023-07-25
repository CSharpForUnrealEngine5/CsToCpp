#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldConditions/WorldCondition_SmartObjectActorTagQuery.h")]
///<summary>World condition to match tags of the Smart Object's owning Actor (which must implement IGameplayTagAssetInterface or have an AbilitySystemComponent).</summary>
public partial struct FWorldCondition_SmartObjectActorTagQuery {
// WorldCondition_SmartObjectActorTagQuery
	public FGameplayTagQuery TagQuery;
}
