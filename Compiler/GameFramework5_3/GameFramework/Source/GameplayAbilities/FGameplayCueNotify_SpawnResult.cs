namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_SpawnResult</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_SpawnResult {
	public TArray<UFXSystemComponent> FxSystemComponents;
	public TArray<UAudioComponent> AudioComponents;
	public TArray<UCameraShakeBase> CameraShakes;
	public TArray<object /*CameraLensEffects*/> CameraLensEffects;
	public UForceFeedbackComponent ForceFeedbackComponent;
	public APlayerController ForceFeedbackTargetPC;
	public UDecalComponent DecalComponent;
}
