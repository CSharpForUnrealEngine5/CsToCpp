#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraLightRendererProperties.h")]
public partial class UNiagaraLightRendererProperties : UNiagaraRendererProperties {
// NiagaraLightRendererProperties
	public ENiagaraRendererSourceDataMode SourceMode;
	public bool bUseInverseSquaredFalloff;
	public bool bAffectsTranslucency;
	public bool bAlphaScalesBrightness;
	public bool bOverrideInverseExposureBlend;
	public float RadiusScale;
	public float DefaultExponent;
	public FVector3f ColorAdd;
	public float InverseExposureBlend;
	public int RendererVisibility;
	public FNiagaraVariableAttributeBinding LightRenderingEnabledBinding;
	public FNiagaraVariableAttributeBinding LightExponentBinding;
	public FNiagaraVariableAttributeBinding PositionBinding;
	public FNiagaraVariableAttributeBinding ColorBinding;
	public FNiagaraVariableAttributeBinding RadiusBinding;
	public FNiagaraVariableAttributeBinding VolumetricScatteringBinding;
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
}
