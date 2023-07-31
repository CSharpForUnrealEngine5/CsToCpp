#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that represents a participating media material around a planet, e.g. clouds.</summary>
[CppInclude("Components/VolumetricCloudComponent.h")]
public partial class UVolumetricCloudComponent : USceneComponent {
	///<summary>The altitude at which the cloud layer starts. (kilometers above the ground)</summary>
	public float LayerBottomAltitude;
	///<summary>The height of the the cloud layer. (kilometers above the layer bottom altitude)</summary>
	public float LayerHeight;
	///<summary>The maximum distance of the volumetric surface before which we will accept to start tracing. (kilometers)</summary>
	public float TracingStartMaxDistance;
	///<summary>Mode to select how the tracing max distance should be interpreted. DistanceFromPointOfView is useful to avoid the top of the cloud layer to be clipped when TracingMaxDistance is shorten for performance.</summary>
	public EVolumetricCloudTracingMaxDistanceMode TracingMaxDistanceMode;
	///<summary>The maximum distance that will be traced inside the cloud layer. (kilometers)</summary>
	public float TracingMaxDistance;
	///<summary>The planet radius used when there is not SkyAtmosphere component present in the scene.</summary>
	public float PlanetRadius;
	///<summary>The ground albedo used to light the cloud from below with respect to the sun light and sky atmosphere.</summary>
	public FColor GroundAlbedo;
	///<summary>The material describing the cloud volume. It must be a Volume domain material.</summary>
	public UMaterialInterface Material;
	///<summary>Whether to apply atmosphere transmittance per sample, instead of using the light global transmittance.</summary>
	public bool bUsePerSampleAtmosphericLightTransmittance;
	///<summary>Occlude the sky light contribution at the bottom of the cloud layer. This is a fast approximation to sky lighting being occluded by cloud without having to trace rays or sample AO texture. Ignored if the cloud material explicitely sets the ambient occlusion value.</summary>
	public float SkyLightCloudBottomOcclusion;
	///<summary>Scale the tracing sample count in primary views. Quality level scalability CVARs affect the maximum range.</summary>
	public float ViewSampleCountScale;
	///<summary>Scale the tracing sample count in reflection views. Quality level scalability CVARs affect the maximum range.</summary>
	public float ReflectionViewSampleCountScaleValue;
	///<summary>ReflectionViewSampleCountScale_DEPRECATED</summary>
	public float ReflectionViewSampleCountScale_DEPRECATED;
	///<summary>ReflectionSampleCountScale_DEPRECATED</summary>
	public float ReflectionSampleCountScale_DEPRECATED;
	///<summary>Scale the shadow tracing sample count in primary views, only used with Advanced Output ray marched shadows. Quality level scalability CVARs affect the maximum range.</summary>
	public float ShadowViewSampleCountScale;
	///<summary>Scale the shadow tracing sample count in reflection views, only used with Advanced Output ray marched shadows. Quality level scalability CVARs affect the maximum range.</summary>
	public float ShadowReflectionViewSampleCountScaleValue;
	///<summary>ShadowReflectionViewSampleCountScale_DEPRECATED</summary>
	public float ShadowReflectionViewSampleCountScale_DEPRECATED;
	///<summary>ShadowReflectionSampleCountScale_DEPRECATED</summary>
	public float ShadowReflectionSampleCountScale_DEPRECATED;
	///<summary>The shadow tracing distance in kilometers, only used with Advanced Output ray marched shadows.</summary>
	public float ShadowTracingDistance;
	///<summary>When the mean transmittance is below this threshold, we stop tracing. This is a good way to reduce the ray marched sample count, and thus to increase performance.</summary>
	public float StopTracingTransmittanceThreshold;
	///<summary>Specify the aerial perspective start distance on cloud for Rayleigh scattering only. (kilometers)</summary>
	public float AerialPespectiveRayleighScatteringStartDistance;
	///<summary>Specify the distance over which the Rayleigh scattering will linearly ramp up to ful leffect. (kilometers)</summary>
	public float AerialPespectiveRayleighScatteringFadeDistance;
	///<summary>Specify the aerial perspective start distance on cloud for Mie scattering only. (kilometers)</summary>
	public float AerialPespectiveMieScatteringStartDistance;
	///<summary>Specify the distance over which the Rayleigh scattering will linearly ramp up to ful leffect. (kilometers)</summary>
	public float AerialPespectiveMieScatteringFadeDistance;
	///<summary>SetLayerBottomAltitude</summary>
	public  void SetLayerBottomAltitude(float NewValue) {}
	///<summary>SetLayerHeight</summary>
	public  void SetLayerHeight(float NewValue) {}
	///<summary>SetTracingStartMaxDistance</summary>
	public  void SetTracingStartMaxDistance(float NewValue) {}
	///<summary>SetTracingMaxDistance</summary>
	public  void SetTracingMaxDistance(float NewValue) {}
	///<summary>SetPlanetRadius</summary>
	public  void SetPlanetRadius(float NewValue) {}
	///<summary>SetGroundAlbedo</summary>
	public  void SetGroundAlbedo(FColor NewValue) {}
	///<summary>SetbUsePerSampleAtmosphericLightTransmittance</summary>
	public  void SetbUsePerSampleAtmosphericLightTransmittance(bool NewValue) {}
	///<summary>SetSkyLightCloudBottomOcclusion</summary>
	public  void SetSkyLightCloudBottomOcclusion(float NewValue) {}
	///<summary>SetViewSampleCountScale</summary>
	public  void SetViewSampleCountScale(float NewValue) {}
	///<summary>SetReflectionViewSampleCountScale</summary>
	public  void SetReflectionViewSampleCountScale(float NewValue) {}
	///<summary>SetShadowViewSampleCountScale</summary>
	public  void SetShadowViewSampleCountScale(float NewValue) {}
	///<summary>SetShadowReflectionViewSampleCountScale</summary>
	public  void SetShadowReflectionViewSampleCountScale(float NewValue) {}
	///<summary>SetShadowTracingDistance</summary>
	public  void SetShadowTracingDistance(float NewValue) {}
	///<summary>SetStopTracingTransmittanceThreshold</summary>
	public  void SetStopTracingTransmittanceThreshold(float NewValue) {}
	///<summary>SetMaterial</summary>
	public  void SetMaterial(UMaterialInterface NewValue) {}
	///<summary>SetReflectionSampleCountScale</summary>
	public  void SetReflectionSampleCountScale(float NewValue) {}
	///<summary>SetShadowReflectionSampleCountScale</summary>
	public  void SetShadowReflectionSampleCountScale(float NewValue) {}
}
