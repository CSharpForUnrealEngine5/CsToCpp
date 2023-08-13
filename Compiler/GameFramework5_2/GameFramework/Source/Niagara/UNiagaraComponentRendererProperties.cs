namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentRendererProperties.h")]
public partial class UNiagaraComponentRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>The scene component class to instantiate</summary>
	public UClass ComponentType;
	///<summary>The max number of components that this emitter will spawn or update each frame.</summary>
	public uint ComponentCountLimit;
	///<summary>Which attribute should we use to check if component rendering should be enabled for a particle? This can be used to control the spawn-rate on a per-particle basis.</summary>
	public FNiagaraVariableAttributeBinding EnabledBinding;
	///<summary>Which attribute should we use to check if component rendering should be enabled for a particle? This can be used to control the spawn-rate on a per-particle basis.</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>If true then components will not be automatically assigned to the first particle available, but try to stick to the same particle based on its unique id.</summary>
	public bool bAssignComponentsOnParticleID;
	///<summary>If true then new components can only be created on newly spawned particles. If a particle is not able to create a component on it&#39;s first frame (e.g. because the component</summary>
	public bool bCreateComponentFirstParticleFrame;
	///<summary>If true then components will only be activated when newly acquired. e.g. on particle spawn or when the particle enables/disables the component.</summary>
	public bool bOnlyActivateNewlyAquiredComponents;
	///<summary>If true then the editor visualization is enabled for the component; has no effect in-game.</summary>
	public bool bVisualizeComponents;
	///<summary>bOnlyCreateComponentsOnParticleSpawn_DEPRECATED</summary>
	public bool bOnlyCreateComponentsOnParticleSpawn_DEPRECATED;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public int RendererVisibility;
	///<summary>The object template used to create new components at runtime.</summary>
	public USceneComponent TemplateComponent;
	///<summary>PropertyBindings</summary>
	public TArray<FNiagaraComponentPropertyBinding> PropertyBindings;
}
