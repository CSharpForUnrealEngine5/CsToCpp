namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reticles allow targeting to be visualized. Tasks can spawn these. Artists/designers can create BPs for these.</summary>
[CppInclude("Abilities/GameplayAbilityWorldReticle.h")]
public partial class AGameplayAbilityWorldReticle : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Called whenever bIsTargetValid changes value.</summary>
	public void OnValidTargetChanged(bool bNewValue) {}
	///<summary>Called whenever bIsTargetAnActor changes value.</summary>
	public void OnTargetingAnActor(bool bNewValue) {}
	///<summary>OnParametersInitialized</summary>
	public void OnParametersInitialized() {}
	///<summary>SetReticleMaterialParamFloat</summary>
	public void SetReticleMaterialParamFloat(string ParamName,float value) {}
	///<summary>SetReticleMaterialParamVector</summary>
	public void SetReticleMaterialParamVector(string ParamName,FVector value) {}
	///<summary>FaceTowardSource</summary>
	public void FaceTowardSource(bool bFaceIn2D) {}
	///<summary>Parameters</summary>
	public FWorldReticleParameters Parameters;
	///<summary>Makes the reticle&#39;s default owner-facing behavior operate in 2D (flat) instead of 3D (pitched). Defaults to true.</summary>
	public bool bFaceOwnerFlat;
	///<summary>If the target is an actor snap to it&#39;s location</summary>
	public bool bSnapToTargetedActor;
	///<summary>This indicates whether or not the targeting actor considers the current target to be valid. Defaults to true.</summary>
	public bool bIsTargetValid;
	///<summary>This indicates whether or not the targeting reticle is pointed at an actor. Defaults to false.</summary>
	public bool bIsTargetAnActor;
	///<summary>This is used in the process of determining whether we should replicate to a specific client.</summary>
	public APlayerController PrimaryPC;
	///<summary>In the future, we may want to grab things like sockets off of this.</summary>
	public AActor TargetingActor;
}
