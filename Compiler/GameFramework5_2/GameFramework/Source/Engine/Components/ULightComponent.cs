#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LightComponent.h")]
public partial class ULightComponent : ULightComponentBase {
// LightComponent
	public float Temperature;
	public float MaxDrawDistance;
	public float MaxDistanceFadeRange;
	public bool bUseTemperature;
	public int ShadowMapChannel_DEPRECATED;
	public float MinRoughness_DEPRECATED;
	public float SpecularScale;
	public float ShadowResolutionScale;
	public float ShadowBias;
	public float ShadowSlopeBias;
	public float ShadowSharpen;
	public float ContactShadowLength;
	public bool ContactShadowLengthInWS;
	public float ContactShadowCastingIntensity;
	public float ContactShadowNonCastingIntensity;
	public bool InverseSquaredFalloff_DEPRECATED;
	public bool CastTranslucentShadows;
	public bool bCastShadowsFromCinematicObjectsOnly;
	public bool bAffectDynamicIndirectLighting;
	public bool bForceCachedShadowsForMovablePrimitives;
	public FLightingChannels LightingChannels;
	public UMaterialInterface LightFunctionMaterial;
	public UMaterialInterface StashedLightFunctionMaterial;
	public FVector LightFunctionScale;
	public UTextureLightProfile IESTexture;
	public bool bUseIESBrightness;
	public float IESBrightnessScale;
	public float LightFunctionFadeDistance;
	public float DisabledBrightness;
	public bool bEnableLightShaftBloom;
	public float BloomScale;
	public float BloomThreshold;
	public float BloomMaxBrightness;
	public FColor BloomTint;
	public bool bUseRayTracedDistanceFieldShadows;
	public float RayStartOffsetDepthScale;
	public  void SetIntensity(float NewIntensity) {}
	public  void SetIndirectLightingIntensity(float NewIntensity) {}
	public  void SetVolumetricScatteringIntensity(float NewIntensity) {}
	public  void SetLightColor(FLinearColor NewLightColor,bool bSRGB/*=true*/) {}
	public  void SetLightFColor(FColor NewLightColor) {}
	public  void SetTemperature(float NewTemperature) {}
	public  void SetUseTemperature(bool bNewValue) {}
	public  void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial) {}
	public  void SetLightFunctionScale(FVector NewLightFunctionScale) {}
	public  void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance) {}
	public  void SetLightFunctionDisabledBrightness(float NewValue) {}
	public  void SetAffectDynamicIndirectLighting(bool bNewValue) {}
	public  void SetAffectTranslucentLighting(bool bNewValue) {}
	public  void SetTransmission(bool bNewValue) {}
	public  void SetEnableLightShaftBloom(bool bNewValue) {}
	public  void SetBloomScale(float NewValue) {}
	public  void SetBloomThreshold(float NewValue) {}
	public  void SetBloomMaxBrightness(float NewValue) {}
	public  void SetBloomTint(FColor NewValue) {}
	public  void SetIESTexture(UTextureLightProfile NewValue) {}
	public  void SetUseIESBrightness(bool bNewValue) {}
	public  void SetIESBrightnessScale(float NewValue) {}
	public  void SetShadowBias(float NewValue) {}
	public  void SetShadowSlopeBias(float NewValue) {}
	public  void SetSpecularScale(float NewValue) {}
	public  void SetForceCachedShadowsForMovablePrimitives(bool bNewValue) {}
	public  void SetLightingChannels(bool bChannel0,bool bChannel1,bool bChannel2) {}
}
