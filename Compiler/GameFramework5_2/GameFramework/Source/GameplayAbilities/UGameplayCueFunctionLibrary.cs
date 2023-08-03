#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGameplayCueFunctionLibrary</summary>
[CppInclude("GameplayCueFunctionLibrary.h")]
public partial class UGameplayCueFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Builds gameplay cue parameters using data from a hit result.</summary>
	public static FGameplayCueParameters MakeGameplayCueParametersFromHitResult(FHitResult HitResult) { return default; }
	///<summary>Invoke a one time &quot;instant&quot; execute event for a gameplay cue on the target actor.</summary>
	public static void ExecuteGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	///<summary>Invoke the added event for a gameplay cue on the target actor. This should be paired with a RemoveGameplayCueOnActor call.</summary>
	public static void AddGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
	///<summary>Invoke the removed event for a gameplay cue on the target actor. This should be paired with an AddGameplayCueOnActor call.</summary>
	public static void RemoveGameplayCueOnActor(AActor Target,FGameplayTag GameplayCueTag,FGameplayCueParameters Parameters) {}
}
