#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Emitter.h")]
public partial class AEmitter : AActor {
// Emitter
	public UParticleSystemComponent ParticleSystemComponent;
	public bool bDestroyOnSystemFinish;
	public bool bPostUpdateTickGroup;
	public bool bCurrentlyActive;
	public FParticleSpawnSignature OnParticleSpawn;
	public FParticleBurstSignature OnParticleBurst;
	public FParticleDeathSignature OnParticleDeath;
	public FParticleCollisionSignature OnParticleCollide;
	public UBillboardComponent SpriteComponent;
	public UArrowComponent ArrowComponent;
	public void OnParticleSystemFinished(UObject FinishedComponent) {}
	public void OnRep_bCurrentlyActive() {}
	public void Activate() {}
	public void Deactivate() {}
	public void ToggleActive() {}
	public bool IsActive() { return default; }
	public void SetTemplate(UObject NewTemplate) {}
	public void SetFloatParameter(string ParameterName,float Param) {}
	public void SetVectorParameter(string ParameterName,FVector Param) {}
	public void SetColorParameter(string ParameterName,FLinearColor Param) {}
	public void SetActorParameter(string ParameterName,UObject Param) {}
	public void SetMaterialParameter(string ParameterName,UObject Param) {}
}
