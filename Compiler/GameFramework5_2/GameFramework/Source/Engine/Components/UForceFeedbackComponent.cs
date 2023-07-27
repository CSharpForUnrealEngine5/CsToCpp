#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ForceFeedbackComponent.h")]
///<summary>ForceFeedbackComponent allows placing a rumble effect in to the world and having it apply to player characters who come near it</summary>
public partial class UForceFeedbackComponent : USceneComponent {
// ForceFeedbackComponent
	public UForceFeedbackEffect ForceFeedbackEffect;
	public bool bAutoDestroy;
	public bool bStopWhenOwnerDestroyed;
	public bool bLooping;
	public bool bIgnoreTimeDilation;
	public bool bOverrideAttenuation;
	public float IntensityMultiplier;
	public UForceFeedbackAttenuation AttenuationSettings;
	public FForceFeedbackAttenuationSettings AttenuationOverrides;
	public FOnForceFeedbackFinished OnForceFeedbackFinished;
	public  void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect) {}
	public  void Play(float StartTime/*=0.0f*/) {}
	public  void Stop() {}
	public  void SetIntensityMultiplier(float NewIntensityMultiplier) {}
	public  void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings) {}
	public  bool BP_GetAttenuationSettingsToApply(FForceFeedbackAttenuationSettings OutAttenuationSettings) { return default; }
}
