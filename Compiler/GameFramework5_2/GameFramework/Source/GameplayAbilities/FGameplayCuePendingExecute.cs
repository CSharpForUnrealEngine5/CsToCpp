namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure to keep track of pending gameplay cues that haven&#39;t been applied yet.</summary>
[CppInclude("GameplayCue_Types.h")]
public partial struct FGameplayCuePendingExecute {
	public FPredictionKey PredictionKey;
	public EGameplayCuePayloadType PayloadType;
	public UAbilitySystemComponent OwningComponent;
	public FGameplayEffectSpecForRPC FromSpec;
	public FGameplayCueParameters CueParameters;
}
