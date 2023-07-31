#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Light/ParticleModuleLight.h")]
public partial class UParticleModuleLight : UParticleModuleLightBase {
	///<summary>Whether to use physically based inverse squared falloff from the light.  If unchecked, the LightExponent distribution will be used instead.</summary>
	public bool bUseInverseSquaredFalloff;
	///<summary>Whether lights from this module should affect translucency.</summary>
	public bool bAffectsTranslucency;
	///<summary>When enabled we will override the project default setting with our local setting.</summary>
	public bool bOverrideInverseExposureBlend;
	///<summary>Will draw wireframe spheres to preview the light radius if enabled.</summary>
	public bool bPreviewLightRadius;
	///<summary>Fraction of particles in this emitter to create lights on.</summary>
	public float SpawnFraction;
	///<summary>Scale that is applied to the particle&#39;s color to calculate the light&#39;s color, and can be setup as a curve over the particle&#39;s lifetime.</summary>
	public FRawDistributionVector ColorScaleOverLife;
	///<summary>Brightness scale for the light, which can be setup as a curve over the particle&#39;s lifetime.</summary>
	public FRawDistributionFloat BrightnessOverLife;
	///<summary>Scales the particle&#39;s radius, to calculate the light&#39;s radius.</summary>
	public FRawDistributionFloat RadiusScale;
	///<summary>Provides the light&#39;s exponent when inverse squared falloff is disabled.</summary>
	public FRawDistributionFloat LightExponent;
	///<summary>Blend Factor used to blend between Intensity and Intensity/Exposure.</summary>
	public float InverseExposureBlend;
	///<summary>Channels that this light should affect.</summary>
	public FLightingChannels LightingChannels;
	///<summary>Intensity of the volumetric scattering from this light.  This scales Intensity and LightColor.</summary>
	public float VolumetricScatteringIntensity;
	///<summary>Converts the particle lights into high quality lights as if they came from a PointLightComponent.  High quality lights cost significantly more on both CPU and GPU.</summary>
	public bool bHighQualityLights;
	///<summary>Whether to cast shadows from the particle lights.  Requires High Quality Lights to be enabled.</summary>
	public bool bShadowCastingLights;
}
