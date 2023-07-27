#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorsBlueprintFunctionLibrary.h")]
public partial class UGameplayBehaviorsBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayBehaviorsBlueprintFunctionLibrary
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	public static void SetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer Value) {}
	public static void AddGameplayTagFilterToBlackboardKeySelector(FBlackboardKeySelector InSelector,UObject Owner,string PropertyName) {}
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTagFromBlackboardComp(UBlackboardComponent BlackboardComp,string KeyName) { return default; }
	public static void SetValueAsGameplayTagForBlackboardComp(UBlackboardComponent BlackboardComp,string KeyName,FGameplayTagContainer GameplayTagValue) {}
}
