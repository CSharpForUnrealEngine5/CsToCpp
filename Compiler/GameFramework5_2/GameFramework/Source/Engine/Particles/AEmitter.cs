#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Emitter.h")]
public partial class AEmitter : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ParticleSystemComponent</summary>
	public UParticleSystemComponent ParticleSystemComponent;
	///<summary>bDestroyOnSystemFinish</summary>
	public bool bDestroyOnSystemFinish;
	///<summary>bPostUpdateTickGroup</summary>
	public bool bPostUpdateTickGroup;
	///<summary>used to update status of toggleable level placed emitters on clients</summary>
	public bool bCurrentlyActive;
	///<summary>OnParticleSpawn</summary>
	public FParticleSpawnSignature OnParticleSpawn;
	///<summary>OnParticleBurst</summary>
	public FParticleBurstSignature OnParticleBurst;
	///<summary>OnParticleDeath</summary>
	public FParticleDeathSignature OnParticleDeath;
	///<summary>OnParticleCollide</summary>
	public FParticleCollisionSignature OnParticleCollide;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
	///<summary>OnParticleSystemFinished</summary>
	public  void OnParticleSystemFinished(UParticleSystemComponent FinishedComponent) {}
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_bCurrentlyActive() {}
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public  void Activate() {}
	///<summary>Deactivate</summary>
	public  void Deactivate() {}
	///<summary>ToggleActive</summary>
	public  void ToggleActive() {}
	///<summary>IsActive</summary>
	public  bool IsActive() { return default; }
	///<summary>SetTemplate</summary>
	public  void SetTemplate(UParticleSystem NewTemplate) {}
	///<summary>SetFloatParameter</summary>
	public  void SetFloatParameter(string ParameterName,float Param) {}
	///<summary>SetVectorParameter</summary>
	public  void SetVectorParameter(string ParameterName,FVector Param) {}
	///<summary>SetColorParameter</summary>
	public  void SetColorParameter(string ParameterName,FLinearColor Param) {}
	///<summary>SetActorParameter</summary>
	public  void SetActorParameter(string ParameterName,AActor Param) {}
	///<summary>SetMaterialParameter</summary>
	public  void SetMaterialParameter(string ParameterName,UMaterialInterface Param) {}
}
