#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_LoopingEffects</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_LoopingEffects {
	public TArray<FGameplayCueNotify_ParticleInfo> LoopingParticles;
	public TArray<FGameplayCueNotify_SoundInfo> LoopingSounds;
	public FGameplayCueNotify_CameraShakeInfo LoopingCameraShake;
	public FGameplayCueNotify_CameraLensEffectInfo LoopingCameraLensEffect;
	public FGameplayCueNotify_ForceFeedbackInfo LoopingForceFeedback;
	public FGameplayCueNotify_InputDevicePropertyInfo LoopingInputDevicePropertyEffect;
}
