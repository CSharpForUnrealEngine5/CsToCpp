namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameplayTagQuery decorator node.</summary>
[CppInclude("AI/BTDecorator_GameplayTagQuery.h")]
public partial class UBTDecorator_GameplayTagQuery : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>ActorForGameplayTagQuery</summary>
	public FBlackboardKeySelector ActorForGameplayTagQuery;
	///<summary>Gameplay tag query to match</summary>
	public FGameplayTagQuery GameplayTagQuery;
	///<summary>QueryTags</summary>
	public TArray<FGameplayTag> QueryTags;
}
