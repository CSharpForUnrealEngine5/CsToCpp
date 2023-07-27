#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomComponent.h")]
public partial class UGroomComponent : UMeshComponent {
// GroomComponent
	public UGroomAsset GroomAsset;
	public UGroomCache GroomCache;
	public TArray<UNiagaraComponent> NiagaraComponents;
	public USkeletalMesh SourceSkeletalMesh;
	public UGroomBindingAsset BindingAsset;
	public UPhysicsAsset PhysicsAsset;
	public FHairSimulationSettings SimulationSettings;
	public UMeshDeformer MeshDeformer;
	public UMeshDeformerInstance MeshDeformerInstance;
	public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings;
	public UMaterialInterface Strands_DebugMaterial;
	public UMaterialInterface Strands_DefaultMaterial;
	public UMaterialInterface Cards_DefaultMaterial;
	public UMaterialInterface Meshes_DefaultMaterial;
	public UNiagaraSystem AngularSpringsSystem;
	public UNiagaraSystem CosseratRodsSystem;
	public string AttachmentName;
	public  void SetGroomAsset(UGroomAsset Asset) {}
	public  void SetBindingAsset(UGroomBindingAsset InBinding) {}
	public  void SetPhysicsAsset(UPhysicsAsset InPhysicsAsset) {}
	public  void SetMeshDeformer(UMeshDeformer InMeshDeformer) {}
	public  void AddCollisionComponent(USkeletalMeshComponent SkeletalMeshComponent) {}
	public  void ResetCollisionComponents() {}
	public  void SetEnableSimulation(bool bInEnableSimulation) {}
	public  void ResetSimulation() {}
	public  UNiagaraComponent GetNiagaraComponent(int GroupIndex) { return default; }
	public  void SetHairLengthScale(float Scale) {}
	public  void SetHairLengthScaleEnable(bool bEnable) {}
	public  bool GetIsHairLengthScaleEnabled() { return default; }
	public TArray<FHairGroupDesc> GroomGroupsDesc;
	public bool bUseCards;
	public bool bRunning;
	public bool bLooping;
	public bool bManualTick;
	public float ElapsedTime;
	public UGroomAsset GroomAssetBeingLoaded;
	public UGroomBindingAsset BindingAssetBeingLoaded;
}
