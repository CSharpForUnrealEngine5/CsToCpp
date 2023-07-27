#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueFunctionLibrary.h")]
///<summary>UGameplayCueFunctionLibrary</summary>
public partial class UGameplayCueFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayCueFunctionLibrary
	public static FGameplayCueParameters MakeGameplayCueParametersFromHitResult(FHitResult HitResult) { return default; }
	public static void ExecuteGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	public static void AddGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	public static void RemoveGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
}
