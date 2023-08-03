#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume.</summary>
[CppInclude("Components/DirectionalLightComponent.h")]
public partial class UDirectionalLightComponent : ULightComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Controls the depth bias scaling across cascades. This allows to mitigage the shadow acne difference on shadow cascades transition.</summary>
	public float ShadowCascadeBiasDistribution;
	///<summary>Whether to occlude fog and atmosphere inscattering with screenspace blurred occlusion from this light.</summary>
	public bool bEnableLightShaftOcclusion;
	///<summary>Controls how dark the occlusion masking is, a value of 1 results in no darkening term.</summary>
	public float OcclusionMaskDarkness;
	///<summary>Everything closer to the camera than this distance will occlude light shafts.</summary>
	public float OcclusionDepthRange;
	///<summary>Can be used to make light shafts come from somewhere other than the light&#39;s actual direction.</summary>
	public FVector LightShaftOverrideDirection;
	///<summary>WholeSceneDynamicShadowRadius_DEPRECATED</summary>
	public float WholeSceneDynamicShadowRadius_DEPRECATED;
	///<summary>How far Cascaded Shadow Map dynamic shadows will cover for a movable light, measured from the camera.</summary>
	public float DynamicShadowDistanceMovableLight;
	///<summary>How far Cascaded Shadow Map dynamic shadows will cover for a stationary light, measured from the camera.</summary>
	public float DynamicShadowDistanceStationaryLight;
	///<summary>Number of cascades to split the view frustum into for the whole scene dynamic shadow.</summary>
	public int DynamicShadowCascades;
	///<summary>Controls whether the cascades are distributed closer to the camera (larger exponent) or further from the camera (smaller exponent).</summary>
	public float CascadeDistributionExponent;
	///<summary>Proportion of the fade region between cascades.</summary>
	public float CascadeTransitionFraction;
	///<summary>Controls the size of the fade out region at the far extent of the dynamic shadow&#39;s influence.</summary>
	public float ShadowDistanceFadeoutFraction;
	///<summary>Stationary lights only: Whether to use per-object inset shadows for movable components, even though cascaded shadow maps are enabled.</summary>
	public bool bUseInsetShadowsForMovableObjects;
	///<summary>0: no DistantShadowCascades, otherwise the count of cascades between WholeSceneDynamicShadowRadius and DistantShadowDistance that are covered by distant shadow cascades.</summary>
	public int FarShadowCascadeCount;
	///<summary>Distance at which the far shadow cascade should end.  Far shadows will cover the range between &#39;Dynamic Shadow Distance&#39; and this distance.</summary>
	public float FarShadowDistance;
	///<summary>Distance at which the ray traced shadow cascade should end.  Distance field shadows will cover the range between &#39;Dynamic Shadow Distance&#39; this distance.</summary>
	public float DistanceFieldShadowDistance;
	///<summary>Forward lighting priority for the single directional light that will be used for forward shading, translucent, single layer water and volumetric fog.</summary>
	public int ForwardShadingPriority;
	///<summary>Angle subtended by light source in degrees (also known as angular diameter).</summary>
	public float LightSourceAngle;
	///<summary>Angle subtended by soft light source in degrees.</summary>
	public float LightSourceSoftAngle;
	///<summary>Shadow source angle factor, relative to the light source angle.</summary>
	public float ShadowSourceAngleFactor;
	///<summary>Determines how far shadows can be cast, in world units.  Larger values increase the shadowing cost.</summary>
	public float TraceDistance;
	///<summary>bUsedAsAtmosphereSunLight_DEPRECATED</summary>
	public bool bUsedAsAtmosphereSunLight_DEPRECATED;
	///<summary>Whether the directional light can interact with the atmosphere, cloud and generate a visual disk. All of which compose the visual sky.</summary>
	public bool bAtmosphereSunLight;
	///<summary>Two atmosphere lights are supported. For instance: a sun and a moon, or two suns.</summary>
	public int AtmosphereSunLightIndex;
	///<summary>A color multiplied with the sun disk luminance.</summary>
	public FLinearColor AtmosphereSunDiskColorScale;
	///<summary>Whether to apply atmosphere transmittance per pixel on opaque meshes, instead of using the light global transmittance. Note: VolumetricCloud per pixel transmittance option is selectable on the VolumetricCloud component itself.</summary>
	public bool bPerPixelAtmosphereTransmittance;
	///<summary>Whether the light should cast any shadows from opaque meshes onto clouds. This is disabled for AtmosphereLight1.</summary>
	public bool bCastShadowsOnClouds;
	///<summary>Whether the light should cast any shadows from opaque meshes onto the atmosphere.</summary>
	public bool bCastShadowsOnAtmosphere;
	///<summary>Whether the light should cast any shadows from clouds onto the atmosphere and other scene elements.</summary>
	public bool bCastCloudShadows;
	///<summary>The overall strength of the cloud shadow, higher value will block more light.</summary>
	public float CloudShadowStrength;
	///<summary>The strength of the shadow on atmosphere. Disabled when 0.</summary>
	public float CloudShadowOnAtmosphereStrength;
	///<summary>The strength of the shadow on opaque and transparent meshes. Disabled when 0.</summary>
	public float CloudShadowOnSurfaceStrength;
	///<summary>The bias applied to the shadow front depth of the volumetric cloud shadow map.</summary>
	public float CloudShadowDepthBias;
	///<summary>The world space radius of the cloud shadow map around the camera in kilometers.</summary>
	public float CloudShadowExtent;
	///<summary>Scale the cloud shadow map resolution, base resolution is 512. The resolution is still clamped to &#39;r.VolumetricCloud.ShadowMap.MaxResolution&#39;.</summary>
	public float CloudShadowMapResolutionScale;
	///<summary>Scale the shadow map tracing sample count.</summary>
	public float CloudShadowRaySampleCountScale;
	///<summary>Scales the lights contribution when scattered in cloud participating media. This can help counter balance the fact that our multiple scattering solution is only an approximation.</summary>
	public FLinearColor CloudScatteredLuminanceScale;
	///<summary>The Lightmass settings for this object.</summary>
	public FLightmassDirectionalLightSettings LightmassSettings;
	///<summary>Whether the light should cast modulated shadows from dynamic objects (mobile only).  Also requires Cast Shadows to be set to True.</summary>
	public bool bCastModulatedShadows;
	///<summary>Color to modulate against the scene color when rendering modulated shadows. (mobile only)</summary>
	public FColor ModulatedShadowColor;
	///<summary>Control the amount of shadow occlusion. A value of 0 means no occlusion, thus no shadow.</summary>
	public float ShadowAmount;
	///<summary>SetDynamicShadowDistanceMovableLight</summary>
	public  void SetDynamicShadowDistanceMovableLight(float NewValue) {}
	///<summary>SetDynamicShadowDistanceStationaryLight</summary>
	public  void SetDynamicShadowDistanceStationaryLight(float NewValue) {}
	///<summary>SetDynamicShadowCascades</summary>
	public  void SetDynamicShadowCascades(int NewValue) {}
	///<summary>SetCascadeDistributionExponent</summary>
	public  void SetCascadeDistributionExponent(float NewValue) {}
	///<summary>SetCascadeTransitionFraction</summary>
	public  void SetCascadeTransitionFraction(float NewValue) {}
	///<summary>SetShadowDistanceFadeoutFraction</summary>
	public  void SetShadowDistanceFadeoutFraction(float NewValue) {}
	///<summary>SetShadowCascadeBiasDistribution</summary>
	public  void SetShadowCascadeBiasDistribution(float NewValue) {}
	///<summary>SetEnableLightShaftOcclusion</summary>
	public  void SetEnableLightShaftOcclusion(bool bNewValue) {}
	///<summary>SetOcclusionMaskDarkness</summary>
	public  void SetOcclusionMaskDarkness(float NewValue) {}
	///<summary>SetOcclusionDepthRange</summary>
	public  void SetOcclusionDepthRange(float NewValue) {}
	///<summary>SetLightShaftOverrideDirection</summary>
	public  void SetLightShaftOverrideDirection(FVector NewValue) {}
	///<summary>SetLightSourceAngle</summary>
	public  void SetLightSourceAngle(float NewValue) {}
	///<summary>SetLightSourceSoftAngle</summary>
	public  void SetLightSourceSoftAngle(float NewValue) {}
	///<summary>SetShadowSourceAngleFactor</summary>
	public  void SetShadowSourceAngleFactor(float NewValue) {}
	///<summary>SetShadowAmount</summary>
	public  void SetShadowAmount(float NewValue) {}
	///<summary>SetAtmosphereSunLight</summary>
	public  void SetAtmosphereSunLight(bool bNewValue) {}
	///<summary>SetAtmosphereSunLightIndex</summary>
	public  void SetAtmosphereSunLightIndex(int NewValue) {}
	///<summary>SetForwardShadingPriority</summary>
	public  void SetForwardShadingPriority(int NewValue) {}
}
