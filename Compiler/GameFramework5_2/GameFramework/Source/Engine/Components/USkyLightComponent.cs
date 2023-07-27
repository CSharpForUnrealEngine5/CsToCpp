#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkyLightComponent.h")]
public partial class USkyLightComponent : ULightComponentBase {
// SkyLightComponent
	public bool bRealTimeCapture;
	public ESkyLightSourceType SourceType;
	public UTextureCube Cubemap;
	public float SourceCubemapAngle;
	public int CubemapResolution;
	public float SkyDistanceThreshold;
	public bool bCaptureEmissiveOnly;
	public bool bLowerHemisphereIsBlack;
	public FLinearColor LowerHemisphereColor;
	public float OcclusionMaxDistance;
	public float Contrast;
	public float OcclusionExponent;
	public float MinOcclusion;
	public FColor OcclusionTint;
	public bool bCloudAmbientOcclusion;
	public float CloudAmbientOcclusionStrength;
	public float CloudAmbientOcclusionExtent;
	public float CloudAmbientOcclusionMapResolutionScale;
	public float CloudAmbientOcclusionApertureScale;
	public EOcclusionCombineMode OcclusionCombineMode;
	public bool bShowIlluminanceMeter;
	public  void SetIntensity(float NewIntensity) {}
	public  void SetIndirectLightingIntensity(float NewIntensity) {}
	public  void SetVolumetricScatteringIntensity(float NewIntensity) {}
	public  void SetLightColor(FLinearColor NewLightColor) {}
	public  void SetCubemap(UTextureCube NewCubemap) {}
	public  void SetSourceCubemapAngle(float NewValue) {}
	public  void SetCubemapBlend(UTextureCube SourceCubemap,UTextureCube DestinationCubemap,float InBlendFraction) {}
	public  void SetLowerHemisphereColor(FLinearColor InLowerHemisphereColor) {}
	public  void SetOcclusionTint(FColor InTint) {}
	public  void SetOcclusionContrast(float InOcclusionContrast) {}
	public  void SetOcclusionExponent(float InOcclusionExponent) {}
	public  void SetMinOcclusion(float InMinOcclusion) {}
	public  void RecaptureSky() {}
	public UTextureCube BlendDestinationCubemap;
}
