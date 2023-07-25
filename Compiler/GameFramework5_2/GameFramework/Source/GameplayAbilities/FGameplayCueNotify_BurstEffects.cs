#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueNotifyTypes.h")]
///<summary>FGameplayCueNotify_BurstEffects</summary>
public partial struct FGameplayCueNotify_BurstEffects {
// GameplayCueNotify_BurstEffects
	public TArray<FGameplayCueNotify_ParticleInfo> BurstParticles;
	public TArray<FGameplayCueNotify_SoundInfo> BurstSounds;
	public FGameplayCueNotify_CameraShakeInfo BurstCameraShake;
	public FGameplayCueNotify_CameraLensEffectInfo BurstCameraLensEffect;
	public FGameplayCueNotify_ForceFeedbackInfo BurstForceFeedback;
	public FGameplayCueNotify_InputDevicePropertyInfo BurstDevicePropertyEffect;
	public FGameplayCueNotify_DecalInfo BurstDecal;
}
