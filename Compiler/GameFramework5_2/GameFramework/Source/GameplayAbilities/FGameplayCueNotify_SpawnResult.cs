#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_SpawnResult</summary>
public partial struct FGameplayCueNotify_SpawnResult {
// GameplayCueNotify_SpawnResult
	public TArray<UFXSystemComponent> FxSystemComponents;
	public TArray<UAudioComponent> AudioComponents;
	public TArray<UCameraShakeBase> CameraShakes;
	public TArray<object /*CameraLensEffects*/> CameraLensEffects;
	public UForceFeedbackComponent ForceFeedbackComponent;
	public APlayerController ForceFeedbackTargetPC;
	public UDecalComponent DecalComponent;
}
