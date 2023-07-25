#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Light/ParticleModuleLight.h")]
public partial class UParticleModuleLight : UParticleModuleLightBase {
// ParticleModuleLight
	public bool bUseInverseSquaredFalloff;
	public bool bAffectsTranslucency;
	public bool bOverrideInverseExposureBlend;
	public bool bPreviewLightRadius;
	public float SpawnFraction;
	public FRawDistributionVector ColorScaleOverLife;
	public FRawDistributionFloat BrightnessOverLife;
	public FRawDistributionFloat RadiusScale;
	public FRawDistributionFloat LightExponent;
	public float InverseExposureBlend;
	public FLightingChannels LightingChannels;
	public float VolumetricScatteringIntensity;
	public bool bHighQualityLights;
	public bool bShadowCastingLights;
}
