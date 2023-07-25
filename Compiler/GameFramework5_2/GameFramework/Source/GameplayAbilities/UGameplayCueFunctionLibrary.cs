#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueFunctionLibrary.h")]
///<summary>UGameplayCueFunctionLibrary</summary>
public partial class UGameplayCueFunctionLibrary : UBlueprintFunctionLibrary {
// GameplayCueFunctionLibrary
	public FGameplayCueParameters MakeGameplayCueParametersFromHitResult(FHitResult HitResult) { return default; }
	public void ExecuteGameplayCueOnActor(UObject Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	public void AddGameplayCueOnActor(UObject Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	public void RemoveGameplayCueOnActor(UObject Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
}
