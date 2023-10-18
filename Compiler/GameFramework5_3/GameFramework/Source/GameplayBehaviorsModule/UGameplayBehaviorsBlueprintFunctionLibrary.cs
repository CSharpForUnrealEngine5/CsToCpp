namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorsBlueprintFunctionLibrary.h")]
public partial class UGameplayBehaviorsBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetBlackboardValueAsGameplayTag</summary>
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key) { return default; }
	///<summary>SetBlackboardValueAsGameplayTag</summary>
	public static void SetBlackboardValueAsGameplayTag(UBTNode NodeOwner,FBlackboardKeySelector Key,FGameplayTagContainer Value) {}
	///<summary>AddGameplayTagFilterToBlackboardKeySelector</summary>
	public static void AddGameplayTagFilterToBlackboardKeySelector(FBlackboardKeySelector InSelector,UObject Owner,FName PropertyName) {}
	///<summary>GetBlackboardValueAsGameplayTagFromBlackboardComp</summary>
	public static FGameplayTagContainer GetBlackboardValueAsGameplayTagFromBlackboardComp(UBlackboardComponent BlackboardComp,FName KeyName) { return default; }
	///<summary>SetValueAsGameplayTagForBlackboardComp</summary>
	public static void SetValueAsGameplayTagForBlackboardComp(UBlackboardComponent BlackboardComp,FName KeyName,FGameplayTagContainer GameplayTagValue) {}
}
