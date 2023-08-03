#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameplayTag decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_CheckGameplayTagsOnActor.h")]
public partial class UBTDecorator_CheckGameplayTagsOnActor : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>ActorToCheck</summary>
	public FBlackboardKeySelector ActorToCheck;
	///<summary>TagsToMatch</summary>
	public EGameplayContainerMatchType TagsToMatch;
	///<summary>GameplayTags</summary>
	public FGameplayTagContainer GameplayTags;
	///<summary>cached description</summary>
	public string CachedDescription;
}
