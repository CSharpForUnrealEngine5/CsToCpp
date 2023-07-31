#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraLightRendererProperties.h")]
public partial class UNiagaraLightRendererProperties : UNiagaraRendererProperties {
	///<summary>Whether or not to draw a single element for the Emitter or to draw the particles.</summary>
	public ENiagaraRendererSourceDataMode SourceMode;
	///<summary>Whether to use physically based inverse squared falloff from the light.  If unchecked, the value from the LightExponent binding will be used instead.</summary>
	public bool bUseInverseSquaredFalloff;
	///<summary>Whether lights from this renderer should affect translucency.</summary>
	public bool bAffectsTranslucency;
	///<summary>When checked, will treat the alpha value of the particle&#39;s color as a multiplier of the light&#39;s brightness.</summary>
	public bool bAlphaScalesBrightness;
	///<summary>When enabled we will override the project default setting with our local setting.</summary>
	public bool bOverrideInverseExposureBlend;
	///<summary>A factor used to scale each particle light radius</summary>
	public float RadiusScale;
	///<summary>The exponent to use for all lights if no exponent binding was found</summary>
	public float DefaultExponent;
	///<summary>A static color shift applied to each rendered light</summary>
	public FVector3f ColorAdd;
	///<summary>Blend Factor used to blend between Intensity and Intensity/Exposure.</summary>
	public float InverseExposureBlend;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public int RendererVisibility;
	///<summary>Which attribute should we use to check if light rendering should be enabled for a particle? This can be used to control the spawn-rate on a per-particle basis.</summary>
	public FNiagaraVariableAttributeBinding LightRenderingEnabledBinding;
	///<summary>Which attribute should we use for the light&#39;s exponent when inverse squared falloff is disabled?</summary>
	public FNiagaraVariableAttributeBinding LightExponentBinding;
	///<summary>Which attribute should we use for position when generating lights?</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Which attribute should we use for light color when generating lights?</summary>
	public FNiagaraVariableAttributeBinding ColorBinding;
	///<summary>Which attribute should we use for light radius when generating lights?</summary>
	public FNiagaraVariableAttributeBinding RadiusBinding;
	///<summary>Which attribute should we use for the intensity of the volumetric scattering from this light? This scales the light&#39;s intensity and color.</summary>
	public FNiagaraVariableAttributeBinding VolumetricScatteringBinding;
	///<summary>Which attribute should we use for the renderer visibility tag?</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
}
