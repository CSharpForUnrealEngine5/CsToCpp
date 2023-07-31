#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameplayTagQuery decorator node.</summary>
[CppInclude("AI/BTDecorator_GameplayTagQuery.h")]
public partial class UBTDecorator_GameplayTagQuery : UBTDecorator {
	///<summary>ActorForGameplayTagQuery</summary>
	public FBlackboardKeySelector ActorForGameplayTagQuery;
	///<summary>Gameplay tag query to match</summary>
	public FGameplayTagQuery GameplayTagQuery;
	///<summary>QueryTags</summary>
	public TArray<FGameplayTag> QueryTags;
}
