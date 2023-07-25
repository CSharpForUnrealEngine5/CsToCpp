#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/VolumetricCloudComponent.h")]
///<summary>A component that represents a participating media material around a planet, e.g. clouds.</summary>
public partial class UVolumetricCloudComponent : USceneComponent {
// VolumetricCloudComponent
	public float LayerBottomAltitude;
	public float LayerHeight;
	public float TracingStartMaxDistance;
	public EVolumetricCloudTracingMaxDistanceMode TracingMaxDistanceMode;
	public float TracingMaxDistance;
	public float PlanetRadius;
	public FColor GroundAlbedo;
	public UMaterialInterface Material;
	public bool bUsePerSampleAtmosphericLightTransmittance;
	public float SkyLightCloudBottomOcclusion;
	public float ViewSampleCountScale;
	public float ReflectionViewSampleCountScaleValue;
	public float ReflectionViewSampleCountScale_DEPRECATED;
	public float ReflectionSampleCountScale_DEPRECATED;
	public float ShadowViewSampleCountScale;
	public float ShadowReflectionViewSampleCountScaleValue;
	public float ShadowReflectionViewSampleCountScale_DEPRECATED;
	public float ShadowReflectionSampleCountScale_DEPRECATED;
	public float ShadowTracingDistance;
	public float StopTracingTransmittanceThreshold;
	public float AerialPespectiveRayleighScatteringStartDistance;
	public float AerialPespectiveRayleighScatteringFadeDistance;
	public float AerialPespectiveMieScatteringStartDistance;
	public float AerialPespectiveMieScatteringFadeDistance;
	public void SetLayerBottomAltitude(float NewValue) {}
	public void SetLayerHeight(float NewValue) {}
	public void SetTracingStartMaxDistance(float NewValue) {}
	public void SetTracingMaxDistance(float NewValue) {}
	public void SetPlanetRadius(float NewValue) {}
	public void SetGroundAlbedo(FColor NewValue) {}
	public void SetbUsePerSampleAtmosphericLightTransmittance(bool NewValue) {}
	public void SetSkyLightCloudBottomOcclusion(float NewValue) {}
	public void SetViewSampleCountScale(float NewValue) {}
	public void SetReflectionViewSampleCountScale(float NewValue) {}
	public void SetShadowViewSampleCountScale(float NewValue) {}
	public void SetShadowReflectionViewSampleCountScale(float NewValue) {}
	public void SetShadowTracingDistance(float NewValue) {}
	public void SetStopTracingTransmittanceThreshold(float NewValue) {}
	public void SetMaterial(UObject NewValue) {}
	public void SetReflectionSampleCountScale(float NewValue) {}
	public void SetShadowReflectionSampleCountScale(float NewValue) {}
}
