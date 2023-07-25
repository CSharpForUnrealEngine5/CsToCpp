#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityWorldReticle.h")]
///<summary>Reticles allow targeting to be visualized. Tasks can spawn these. Artists/designers can create BPs for these.</summary>
public partial class AGameplayAbilityWorldReticle : AActor {
// GameplayAbilityWorldReticle
	public void OnValidTargetChanged(bool bNewValue) {}
	public void OnTargetingAnActor(bool bNewValue) {}
	public void OnParametersInitialized() {}
	public void SetReticleMaterialParamFloat(string ParamName,float value) {}
	public void SetReticleMaterialParamVector(string ParamName,FVector value) {}
	public void FaceTowardSource(bool bFaceIn2D) {}
	public FWorldReticleParameters Parameters;
	public bool bFaceOwnerFlat;
	public bool bSnapToTargetedActor;
	public bool bIsTargetValid;
	public bool bIsTargetAnActor;
	public APlayerController PrimaryPC;
	public AActor TargetingActor;
}
