#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_CheckGameplayTagsOnActor.h")]
///<summary>GameplayTag decorator node.</summary>
public partial class UBTDecorator_CheckGameplayTagsOnActor : UBTDecorator {
// BTDecorator_CheckGameplayTagsOnActor
	public FBlackboardKeySelector ActorToCheck;
	public EGameplayContainerMatchType TagsToMatch;
	public FGameplayTagContainer GameplayTags;
	public string CachedDescription;
}
