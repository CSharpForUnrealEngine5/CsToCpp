#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentRendererProperties.h")]
public partial class UNiagaraComponentRendererProperties : UNiagaraRendererProperties {
// NiagaraComponentRendererProperties
	public UClass ComponentType;
	public uint ComponentCountLimit;
	public FNiagaraVariableAttributeBinding EnabledBinding;
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	public bool bAssignComponentsOnParticleID;
	public bool bCreateComponentFirstParticleFrame;
	public bool bOnlyActivateNewlyAquiredComponents;
	public bool bVisualizeComponents;
	public bool bOnlyCreateComponentsOnParticleSpawn_DEPRECATED;
	public int RendererVisibility;
	public USceneComponent TemplateComponent;
	public TArray<FNiagaraComponentPropertyBinding> PropertyBindings;
}
