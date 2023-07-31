#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkyLightComponent.h")]
public partial class USkyLightComponent : ULightComponentBase {
	///<summary>When enabled, the sky will be captured and convolved to achieve dynamic diffuse and specular environment lighting.</summary>
	public bool bRealTimeCapture;
	///<summary>Indicates where to get the light contribution from.</summary>
	public ESkyLightSourceType SourceType;
	///<summary>Cubemap to use for sky lighting if SourceType is set to SLS_SpecifiedCubemap.</summary>
	public UTextureCube Cubemap;
	///<summary>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap.</summary>
	public float SourceCubemapAngle;
	///<summary>Maximum resolution for the very top processed cubemap mip. Must be a power of 2.</summary>
	public int CubemapResolution;
	///<summary>Distance from the sky light at which any geometry should be treated as part of the sky.</summary>
	public float SkyDistanceThreshold;
	///<summary>Only capture emissive materials. Skips all lighting making the capture cheaper. Recomended when using CaptureEveryFrame</summary>
	public bool bCaptureEmissiveOnly;
	///<summary>Whether all distant lighting from the lower hemisphere should be set to LowerHemisphereColor.</summary>
	public bool bLowerHemisphereIsBlack;
	///<summary>LowerHemisphereColor</summary>
	public FLinearColor LowerHemisphereColor;
	///<summary>Max distance that the occlusion of one point will affect another.</summary>
	public float OcclusionMaxDistance;
	///<summary>Contrast S-curve applied to the computed AO.  A value of 0 means no contrast increase, 1 is a significant contrast increase.</summary>
	public float Contrast;
	///<summary>Exponent applied to the computed AO.  Values lower than 1 brighten occlusion overall without losing contact shadows.</summary>
	public float OcclusionExponent;
	///<summary>Controls the darkest that a fully occluded area can get.  This tends to destroy contact shadows, use Contrast or OcclusionExponent instead.</summary>
	public float MinOcclusion;
	///<summary>Tint color on occluded areas, artistic control.</summary>
	public FColor OcclusionTint;
	///<summary>Whether the cloud should occlude sky contribution within the atmosphere (progressively fading multiple scattering out) or not.</summary>
	public bool bCloudAmbientOcclusion;
	///<summary>The strength of the ambient occlusion, higher value will block more light.</summary>
	public float CloudAmbientOcclusionStrength;
	///<summary>The world space radius of the cloud ambient occlusion map around the camera in kilometers.</summary>
	public float CloudAmbientOcclusionExtent;
	///<summary>Scale the cloud ambient occlusion map resolution, base resolution is 512. The resolution is still clamped to &#39;r.VolumetricCloud.SkyAO.MaxResolution&#39;.</summary>
	public float CloudAmbientOcclusionMapResolutionScale;
	///<summary>Controls the cone aperture angle over which the sky occlusion due to volumetric clouds is evaluated. A value of 1 means `take into account the entire hemisphere` resulting in blurry occlusion, while a value of 0 means `take into account a single up occlusion direction up` resulting in sharp occlusion.</summary>
	public float CloudAmbientOcclusionApertureScale;
	///<summary>Controls how occlusion from Distance Field Ambient Occlusion is combined with Screen Space Ambient Occlusion.</summary>
	public EOcclusionCombineMode OcclusionCombineMode;
	///<summary>When enabled, visualize on screen the sky cube map as well as the integrate half hemisphere of luminance, together with the sky illuminance contribution at the position of the skylight component.</summary>
	public bool bShowIlluminanceMeter;
	///<summary>SetIntensity</summary>
	public  void SetIntensity(float NewIntensity) {}
	///<summary>SetIndirectLightingIntensity</summary>
	public  void SetIndirectLightingIntensity(float NewIntensity) {}
	///<summary>SetVolumetricScatteringIntensity</summary>
	public  void SetVolumetricScatteringIntensity(float NewIntensity) {}
	///<summary>Set color of the light</summary>
	public  void SetLightColor(FLinearColor NewLightColor) {}
	///<summary>Sets the cubemap used when SourceType is set to SpecifiedCubemap, and causes a skylight update on the next tick.</summary>
	public  void SetCubemap(UTextureCube NewCubemap) {}
	///<summary>Sets the angle of the cubemap used when SourceType is set to SpecifiedCubemap and it is non static. It will cause the skylight to update on the next tick.</summary>
	public  void SetSourceCubemapAngle(float NewValue) {}
	///<summary>Creates sky lighting from a blend between two cubemaps, which is only valid when SourceType is set to SpecifiedCubemap.</summary>
	public  void SetCubemapBlend(UTextureCube SourceCubemap,UTextureCube DestinationCubemap,float InBlendFraction) {}
	///<summary>SetLowerHemisphereColor</summary>
	public  void SetLowerHemisphereColor(FLinearColor InLowerHemisphereColor) {}
	///<summary>SetOcclusionTint</summary>
	public  void SetOcclusionTint(FColor InTint) {}
	///<summary>SetOcclusionContrast</summary>
	public  void SetOcclusionContrast(float InOcclusionContrast) {}
	///<summary>SetOcclusionExponent</summary>
	public  void SetOcclusionExponent(float InOcclusionExponent) {}
	///<summary>SetMinOcclusion</summary>
	public  void SetMinOcclusion(float InMinOcclusion) {}
	///<summary>Recaptures the scene for the skylight.</summary>
	public  void RecaptureSky() {}
	///<summary>BlendDestinationCubemap</summary>
	public UTextureCube BlendDestinationCubemap;
}
