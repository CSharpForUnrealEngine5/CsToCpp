#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorsBlueprintFunctionLibrary.h")]
public partial class UGameplayBehaviorsBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayBehaviorsBlueprintFunctionLibrary
	public FGameplayTagContainer GetBlackboardValueAsGameplayTag(UObject NodeOwner,FBlackboardKeySelector Key) { return default; }
	public void SetBlackboardValueAsGameplayTag(UObject NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer Value) {}
	public void AddGameplayTagFilterToBlackboardKeySelector(FBlackboardKeySelector InSelector,UObject Owner,string PropertyName) {}
	public FGameplayTagContainer GetBlackboardValueAsGameplayTagFromBlackboardComp(UObject BlackboardComp,string KeyName) { return default; }
	public void SetValueAsGameplayTagForBlackboardComp(UObject BlackboardComp,string KeyName,FGameplayTagContainer GameplayTagValue) {}
}
