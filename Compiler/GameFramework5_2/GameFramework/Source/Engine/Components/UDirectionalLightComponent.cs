#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DirectionalLightComponent.h")]
///<summary>A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume.</summary>
public partial class UDirectionalLightComponent : ULightComponent {
// DirectionalLightComponent
	public float ShadowCascadeBiasDistribution;
	public bool bEnableLightShaftOcclusion;
	public float OcclusionMaskDarkness;
	public float OcclusionDepthRange;
	public FVector LightShaftOverrideDirection;
	public float WholeSceneDynamicShadowRadius_DEPRECATED;
	public float DynamicShadowDistanceMovableLight;
	public float DynamicShadowDistanceStationaryLight;
	public int DynamicShadowCascades;
	public float CascadeDistributionExponent;
	public float CascadeTransitionFraction;
	public float ShadowDistanceFadeoutFraction;
	public bool bUseInsetShadowsForMovableObjects;
	public int FarShadowCascadeCount;
	public float FarShadowDistance;
	public float DistanceFieldShadowDistance;
	public int ForwardShadingPriority;
	public float LightSourceAngle;
	public float LightSourceSoftAngle;
	public float ShadowSourceAngleFactor;
	public float TraceDistance;
	public bool bUsedAsAtmosphereSunLight_DEPRECATED;
	public bool bAtmosphereSunLight;
	public int AtmosphereSunLightIndex;
	public FLinearColor AtmosphereSunDiskColorScale;
	public bool bPerPixelAtmosphereTransmittance;
	public bool bCastShadowsOnClouds;
	public bool bCastShadowsOnAtmosphere;
	public bool bCastCloudShadows;
	public float CloudShadowStrength;
	public float CloudShadowOnAtmosphereStrength;
	public float CloudShadowOnSurfaceStrength;
	public float CloudShadowDepthBias;
	public float CloudShadowExtent;
	public float CloudShadowMapResolutionScale;
	public float CloudShadowRaySampleCountScale;
	public FLinearColor CloudScatteredLuminanceScale;
	public FLightmassDirectionalLightSettings LightmassSettings;
	public bool bCastModulatedShadows;
	public FColor ModulatedShadowColor;
	public float ShadowAmount;
	public void SetDynamicShadowDistanceMovableLight(float NewValue) {}
	public void SetDynamicShadowDistanceStationaryLight(float NewValue) {}
	public void SetDynamicShadowCascades(int NewValue) {}
	public void SetCascadeDistributionExponent(float NewValue) {}
	public void SetCascadeTransitionFraction(float NewValue) {}
	public void SetShadowDistanceFadeoutFraction(float NewValue) {}
	public void SetShadowCascadeBiasDistribution(float NewValue) {}
	public void SetEnableLightShaftOcclusion(bool bNewValue) {}
	public void SetOcclusionMaskDarkness(float NewValue) {}
	public void SetOcclusionDepthRange(float NewValue) {}
	public void SetLightShaftOverrideDirection(FVector NewValue) {}
	public void SetLightSourceAngle(float NewValue) {}
	public void SetLightSourceSoftAngle(float NewValue) {}
	public void SetShadowSourceAngleFactor(float NewValue) {}
	public void SetShadowAmount(float NewValue) {}
	public void SetAtmosphereSunLight(bool bNewValue) {}
	public void SetAtmosphereSunLightIndex(int NewValue) {}
	public void SetForwardShadingPriority(int NewValue) {}
}
