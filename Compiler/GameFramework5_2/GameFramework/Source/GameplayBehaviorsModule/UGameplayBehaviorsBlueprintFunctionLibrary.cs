#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorsBlueprintFunctionLibrary.h")]
public partial class UGameplayBehaviorsBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>GetBlackboardValueAsGameplayTag</summary>
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>SetBlackboardValueAsGameplayTag</summary>
	public static void SetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer Value) {}
	///<summary>AddGameplayTagFilterToBlackboardKeySelector</summary>
	public static void AddGameplayTagFilterToBlackboardKeySelector(FBlackboardKeySelector InSelector,UObject Owner,string PropertyName) {}
	///<summary>GetBlackboardValueAsGameplayTagFromBlackboardComp</summary>
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTagFromBlackboardComp(UBlackboardComponent BlackboardComp,string KeyName) { return default; }
	///<summary>SetValueAsGameplayTagForBlackboardComp</summary>
	public static void SetValueAsGameplayTagForBlackboardComp(UBlackboardComponent BlackboardComp,string KeyName,FGameplayTagContainer GameplayTagValue) {}
}
