#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>World condition to match tags of the Smart Object&#39;s owning Actor (which must implement IGameplayTagAssetInterface or have an AbilitySystemComponent).</summary>
[CppInclude("WorldConditions/WorldCondition_SmartObjectActorTagQuery.h")]
public partial struct FWorldCondition_SmartObjectActorTagQuery {
	public FGameplayTagQuery TagQuery;
}
