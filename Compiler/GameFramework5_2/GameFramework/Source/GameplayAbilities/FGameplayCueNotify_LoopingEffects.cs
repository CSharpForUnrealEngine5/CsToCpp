#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_LoopingEffects</summary>
public partial struct FGameplayCueNotify_LoopingEffects {
// GameplayCueNotify_LoopingEffects
	public TArray<FGameplayCueNotify_ParticleInfo> LoopingParticles;
	public TArray<FGameplayCueNotify_SoundInfo> LoopingSounds;
	public FGameplayCueNotify_CameraShakeInfo LoopingCameraShake;
	public FGameplayCueNotify_CameraLensEffectInfo LoopingCameraLensEffect;
	public FGameplayCueNotify_ForceFeedbackInfo LoopingForceFeedback;
	public FGameplayCueNotify_InputDevicePropertyInfo LoopingInputDevicePropertyEffect;
}
