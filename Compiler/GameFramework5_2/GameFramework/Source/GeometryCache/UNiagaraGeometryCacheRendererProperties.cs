#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGeometryCacheRendererProperties.h")]
public partial class UNiagaraGeometryCacheRendererProperties : UNiagaraRendererProperties {
// NiagaraGeometryCacheRendererProperties
	public TArray<FNiagaraGeometryCacheReference> GeometryCaches;
	public bool bIsLooping;
	public uint ComponentCountLimit;
	public FNiagaraVariableAttributeBinding PositionBinding;
	public FNiagaraVariableAttributeBinding RotationBinding;
	public FNiagaraVariableAttributeBinding ScaleBinding;
	public FNiagaraVariableAttributeBinding ElapsedTimeBinding;
	public FNiagaraVariableAttributeBinding EnabledBinding;
	public FNiagaraVariableAttributeBinding ArrayIndexBinding;
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	public int RendererVisibility;
	public bool bAssignComponentsOnParticleID;
}
