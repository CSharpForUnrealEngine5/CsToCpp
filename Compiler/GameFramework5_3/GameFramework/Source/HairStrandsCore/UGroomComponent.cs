namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomComponent.h")]
public partial class UGroomComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Groom asset .</summary>
	public UGroomAsset GroomAsset;
	///<summary>GroomCache</summary>
	public UGroomCache GroomCache;
	///<summary>Niagara components that will be attached to the system</summary>
	public TArray<UNiagaraComponent> NiagaraComponents;
	///<summary>Kept for debugging mesh transfer</summary>
	public USkeletalMesh SourceSkeletalMesh;
	///<summary>Optional binding asset for binding a groom onto a skeletal mesh. If the binding asset is not provided the projection is done at runtime, which implies a large GPU cost at startup time.</summary>
	public UGroomBindingAsset BindingAsset;
	///<summary>Physics asset to be used for hair simulation</summary>
	public UPhysicsAsset PhysicsAsset;
	///<summary>Groom&#39;s simulation settings</summary>
	public FHairSimulationSettings SimulationSettings;
	///<summary>If set the MeshDeformer will be applied on groom instance for deformation.</summary>
	public UMeshDeformer MeshDeformer;
	///<summary>Object containing state for the bound MeshDeformer.</summary>
	public UMeshDeformerInstance MeshDeformerInstance;
	///<summary>Object containing instance settings for the bound MeshDeformer.</summary>
	public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings;
	///<summary>Reference of the default/debug materials for each geometric representation</summary>
	public UMaterialInterface Strands_DebugMaterial;
	///<summary>Strands_DefaultMaterial</summary>
	public UMaterialInterface Strands_DefaultMaterial;
	///<summary>Cards_DefaultMaterial</summary>
	public UMaterialInterface Cards_DefaultMaterial;
	///<summary>Meshes_DefaultMaterial</summary>
	public UMaterialInterface Meshes_DefaultMaterial;
	///<summary>AngularSpringsSystem</summary>
	public UNiagaraSystem AngularSpringsSystem;
	///<summary>CosseratRodsSystem</summary>
	public UNiagaraSystem CosseratRodsSystem;
	///<summary>Optional socket name, where the groom component should be attached at, when parented with a skeletal mesh</summary>
	public string AttachmentName;
	///<summary>Accessor function for changing Groom asset from blueprint/sequencer</summary>
	public void SetGroomAsset(UGroomAsset Asset) {}
	///<summary>Accessor function for changing Groom binding asset from blueprint/sequencer</summary>
	public void SetBindingAsset(UGroomBindingAsset InBinding) {}
	///<summary>Accessor function for changing Groom physics asset from blueprint/sequencer</summary>
	public void SetPhysicsAsset(UPhysicsAsset InPhysicsAsset) {}
	///<summary>Change the MeshDeformer that is used for this Component.</summary>
	public void SetMeshDeformer(UMeshDeformer InMeshDeformer) {}
	///<summary>Add a skeletal mesh to the collision components</summary>
	public void AddCollisionComponent(USkeletalMeshComponent SkeletalMeshComponent) {}
	///<summary>Reset the collision components</summary>
	public void ResetCollisionComponents() {}
	///<summary>Accessor function for changing the enable simulation flag from blueprint/sequencer</summary>
	public void SetEnableSimulation(bool bInEnableSimulation) {}
	///<summary>Reset the simulation, if enabled</summary>
	public void ResetSimulation() {}
	///<summary>Given the group index return the matching niagara component</summary>
	public UNiagaraComponent GetNiagaraComponent(int GroupIndex) { return default; }
	///<summary>Accessor function for changing hair length scale from blueprint/sequencer</summary>
	public void SetHairLengthScale(float Scale) {}
	///<summary>SetHairLengthScaleEnable</summary>
	public void SetHairLengthScaleEnable(bool bEnable) {}
	///<summary>GetIsHairLengthScaleEnabled</summary>
	public bool GetIsHairLengthScaleEnabled() { return default; }
	///<summary>Groom&#39;s groups info.</summary>
	public TArray<FHairGroupDesc> GroomGroupsDesc;
	///<summary>Force the groom to use cards/meshes geometry instead of strands.</summary>
	public bool bUseCards;
	///<summary>bRunning</summary>
	public bool bRunning;
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>bManualTick</summary>
	public bool bManualTick;
	///<summary>ElapsedTime</summary>
	public float ElapsedTime;
	///<summary>GroomAssetBeingLoaded</summary>
	public UGroomAsset GroomAssetBeingLoaded;
	///<summary>BindingAssetBeingLoaded</summary>
	public UGroomBindingAsset BindingAssetBeingLoaded;
}
