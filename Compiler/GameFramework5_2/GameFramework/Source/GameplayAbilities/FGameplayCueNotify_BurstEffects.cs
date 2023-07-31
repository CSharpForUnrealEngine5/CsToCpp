#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FGameplayCueNotify_BurstEffects</summary>
[CppInclude("GameplayCueNotifyTypes.h")]
public partial struct FGameplayCueNotify_BurstEffects {
	public TArray<FGameplayCueNotify_ParticleInfo> BurstParticles;
	public TArray<FGameplayCueNotify_SoundInfo> BurstSounds;
	public FGameplayCueNotify_CameraShakeInfo BurstCameraShake;
	public FGameplayCueNotify_CameraLensEffectInfo BurstCameraLensEffect;
	public FGameplayCueNotify_ForceFeedbackInfo BurstForceFeedback;
	public FGameplayCueNotify_InputDevicePropertyInfo BurstDevicePropertyEffect;
	public FGameplayCueNotify_DecalInfo BurstDecal;
}
