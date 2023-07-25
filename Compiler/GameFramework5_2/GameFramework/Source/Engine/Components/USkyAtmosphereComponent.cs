#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkyAtmosphereComponent.h")]
///<summary>A component that represents a planet atmosphere material and simulates sky and light scattering within it.</summary>
public partial class USkyAtmosphereComponent : USceneComponent {
// SkyAtmosphereComponent
	public ESkyAtmosphereTransformMode TransformMode;
	public float BottomRadius;
	public FColor GroundAlbedo;
	public float AtmosphereHeight;
	public float MultiScatteringFactor;
	public float TraceSampleCountScale;
	public float RayleighScatteringScale;
	public FLinearColor RayleighScattering;
	public float RayleighExponentialDistribution;
	public float MieScatteringScale;
	public FLinearColor MieScattering;
	public float MieAbsorptionScale;
	public FLinearColor MieAbsorption;
	public float MieAnisotropy;
	public float MieExponentialDistribution;
	public float OtherAbsorptionScale;
	public FLinearColor OtherAbsorption;
	public FTentDistribution OtherTentDistribution;
	public FLinearColor SkyLuminanceFactor;
	public float AerialPespectiveViewDistanceScale;
	public float HeightFogContribution;
	public float TransmittanceMinLightElevationAngle;
	public float AerialPerspectiveStartDepth;
	public void OverrideAtmosphereLightDirection(int AtmosphereLightIndex,FVector LightDirection) {}
	public bool IsAtmosphereLightDirectionOverriden(int AtmosphereLightIndex) { return default; }
	public FVector GetOverridenAtmosphereLightDirection(int AtmosphereLightIndex) { return default; }
	public void ResetAtmosphereLightDirectionOverride(int AtmosphereLightIndex) {}
	public void SetAtmosphereHeight(float NewValue) {}
	public void SetMultiScatteringFactor(float NewValue) {}
	public void SetRayleighScatteringScale(float NewValue) {}
	public void SetRayleighScattering(FLinearColor NewValue) {}
	public void SetRayleighExponentialDistribution(float NewValue) {}
	public void SetMieScatteringScale(float NewValue) {}
	public void SetMieScattering(FLinearColor NewValue) {}
	public void SetMieAbsorptionScale(float NewValue) {}
	public void SetMieAbsorption(FLinearColor NewValue) {}
	public void SetMieAnisotropy(float NewValue) {}
	public void SetMieExponentialDistribution(float NewValue) {}
	public void SetOtherAbsorptionScale(float NewValue) {}
	public void SetOtherAbsorption(FLinearColor NewValue) {}
	public void SetSkyLuminanceFactor(FLinearColor NewValue) {}
	public void SetAerialPespectiveViewDistanceScale(float NewValue) {}
	public void SetHeightFogContribution(float NewValue) {}
	public FLinearColor GetAtmosphereTransmitanceOnGroundAtPlanetTop(UObject DirectionalLight) { return default; }
	public FGuid bStaticLightingBuiltGUID;
}
