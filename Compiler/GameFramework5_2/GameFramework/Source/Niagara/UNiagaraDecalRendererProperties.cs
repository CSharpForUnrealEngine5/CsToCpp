#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDecalRendererProperties.h")]
public partial class UNiagaraDecalRendererProperties : UNiagaraRendererProperties {
// NiagaraDecalRendererProperties
	public UMaterialInterface Material;
	public UMaterialInstanceConstant MICMaterial;
	public FNiagaraParameterBinding MaterialParameterBinding;
	public ENiagaraRendererSourceDataMode SourceMode;
	public int RendererVisibility;
	public float DecalScreenSizeFade;
	public FNiagaraVariableAttributeBinding PositionBinding;
	public FNiagaraVariableAttributeBinding DecalOrientationBinding;
	public FNiagaraVariableAttributeBinding DecalSizeBinding;
	public FNiagaraVariableAttributeBinding DecalFadeBinding;
	public FNiagaraVariableAttributeBinding DecalSortOrderBinding;
	public FNiagaraVariableAttributeBinding DecalColorBinding;
	public FNiagaraVariableAttributeBinding DecalVisibleBinding;
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	public FNiagaraRendererMaterialParameters MaterialParameters;
}
