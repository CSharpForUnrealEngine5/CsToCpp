#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ExponentialHeightFogComponent.h")]
///<summary>Used to create fogging effects such as clouds but with a density that is related to the height of the fog.</summary>
public partial class UExponentialHeightFogComponent : USceneComponent {
// ExponentialHeightFogComponent
	public float FogDensity;
	public float FogHeightFalloff;
	public FExponentialHeightFogData SecondFogData;
	public FLinearColor FogInscatteringColor_DEPRECATED;
	public FLinearColor FogInscatteringLuminance;
	public FLinearColor SkyAtmosphereAmbientContributionColorScale;
	public UTextureCube InscatteringColorCubemap;
	public float InscatteringColorCubemapAngle;
	public FLinearColor InscatteringTextureTint;
	public float FullyDirectionalInscatteringColorDistance;
	public float NonDirectionalInscatteringColorDistance;
	public float DirectionalInscatteringExponent;
	public float DirectionalInscatteringStartDistance;
	public FLinearColor DirectionalInscatteringColor_DEPRECATED;
	public FLinearColor DirectionalInscatteringLuminance;
	public float FogMaxOpacity;
	public float StartDistance;
	public float FogCutoffDistance;
	public bool bEnableVolumetricFog;
	public float VolumetricFogScatteringDistribution;
	public FColor VolumetricFogAlbedo;
	public FLinearColor VolumetricFogEmissive;
	public float VolumetricFogExtinctionScale;
	public float VolumetricFogDistance;
	public float VolumetricFogStartDistance;
	public float VolumetricFogNearFadeInDistance;
	public float VolumetricFogStaticLightingScatteringIntensity;
	public bool bOverrideLightColorsWithFogInscatteringColors;
	public void SetFogDensity(float Value) {}
	public void SetSecondFogDensity(float Value) {}
	public void SetFogInscatteringColor(FLinearColor Value) {}
	public void SetInscatteringColorCubemap(UObject Value) {}
	public void SetInscatteringColorCubemapAngle(float Value) {}
	public void SetFullyDirectionalInscatteringColorDistance(float Value) {}
	public void SetNonDirectionalInscatteringColorDistance(float Value) {}
	public void SetInscatteringTextureTint(FLinearColor Value) {}
	public void SetDirectionalInscatteringExponent(float Value) {}
	public void SetDirectionalInscatteringStartDistance(float Value) {}
	public void SetDirectionalInscatteringColor(FLinearColor Value) {}
	public void SetSecondFogHeightOffset(float Value) {}
	public void SetFogHeightFalloff(float Value) {}
	public void SetSecondFogHeightFalloff(float Value) {}
	public void SetFogMaxOpacity(float Value) {}
	public void SetStartDistance(float Value) {}
	public void SetFogCutoffDistance(float Value) {}
	public void SetVolumetricFog(bool bNewValue) {}
	public void SetVolumetricFogScatteringDistribution(float NewValue) {}
	public void SetVolumetricFogExtinctionScale(float NewValue) {}
	public void SetVolumetricFogAlbedo(FColor NewValue) {}
	public void SetVolumetricFogEmissive(FLinearColor NewValue) {}
	public void SetVolumetricFogDistance(float NewValue) {}
	public void SetSecondFogData(FExponentialHeightFogData NewValue) {}
}
