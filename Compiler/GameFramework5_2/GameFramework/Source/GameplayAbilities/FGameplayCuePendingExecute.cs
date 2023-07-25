#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCue_Types.h")]
///<summary>Structure to keep track of pending gameplay cues that haven't been applied yet.</summary>
public partial struct FGameplayCuePendingExecute {
// GameplayCuePendingExecute
	public FPredictionKey PredictionKey;
	public EGameplayCuePayloadType PayloadType;
	public UAbilitySystemComponent OwningComponent;
	public FGameplayEffectSpecForRPC FromSpec;
	public FGameplayCueParameters CueParameters;
}
