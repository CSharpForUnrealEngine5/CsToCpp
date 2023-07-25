#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/BTDecorator_GameplayTagQuery.h")]
///<summary>GameplayTagQuery decorator node.</summary>
public partial class UBTDecorator_GameplayTagQuery : UBTDecorator {
// BTDecorator_GameplayTagQuery
	public FBlackboardKeySelector ActorForGameplayTagQuery;
	public FGameplayTagQuery GameplayTagQuery;
	public TArray<FGameplayTag> QueryTags;
}
