#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that represents a planet atmosphere material and simulates sky and light scattering within it.</summary>
[CppInclude("Components/SkyAtmosphereComponent.h")]
public partial class USkyAtmosphereComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The ground albedo that will tint the atmosphere when the sun light will bounce on it. Only taken into account when MultiScattering&gt;0.0.</summary>
	public ESkyAtmosphereTransformMode TransformMode;
	///<summary>The radius in kilometers from the center of the planet to the ground level.</summary>
	public float BottomRadius;
	///<summary>The ground albedo that will tint the atmosphere when the sun light will bounce on it. Only taken into account when MultiScattering&gt;0.0.</summary>
	public FColor GroundAlbedo;
	///<summary>The height of the atmosphere layer above the ground in kilometers.</summary>
	public float AtmosphereHeight;
	///<summary>Factor applied to multiple scattering only (after the sun light has bounced around in the atmosphere at least once).</summary>
	public float MultiScatteringFactor;
	///<summary>Scale the atmosphere tracing sample count. Quality level scalability</summary>
	public float TraceSampleCountScale;
	///<summary>Rayleigh scattering coefficient scale.</summary>
	public float RayleighScatteringScale;
	///<summary>The Rayleigh scattering coefficients resulting from molecules in the air at an altitude of 0 kilometer.</summary>
	public FLinearColor RayleighScattering;
	///<summary>The altitude in kilometer at which Rayleigh scattering effect is reduced to 40%.</summary>
	public float RayleighExponentialDistribution;
	///<summary>Mie scattering coefficient scale.</summary>
	public float MieScatteringScale;
	///<summary>The Mie scattering coefficients resulting from particles in the air at an altitude of 0 kilometer. As it becomes higher, light will be scattered more.</summary>
	public FLinearColor MieScattering;
	///<summary>Mie absorption coefficient scale.</summary>
	public float MieAbsorptionScale;
	///<summary>The Mie absorption coefficients resulting from particles in the air at an altitude of 0 kilometer. As it becomes higher, light will be absorbed more.</summary>
	public FLinearColor MieAbsorption;
	///<summary>A value of 0 mean light is uniformly scattered. A value closer to 1 means lights will scatter more forward, resulting in halos around light sources.</summary>
	public float MieAnisotropy;
	///<summary>The altitude in kilometer at which Mie effects are reduced to 40%.</summary>
	public float MieExponentialDistribution;
	///<summary>Absorption coefficients for another atmosphere layer. Density increase from 0 to 1 between 10 to 25km and decreases from 1 to 0 between 25 to 40km. This approximates ozone molecules distribution in the Earth atmosphere.</summary>
	public float OtherAbsorptionScale;
	///<summary>Absorption coefficients for another atmosphere layer. Density increase from 0 to 1 between 10 to 25km and decreases from 1 to 0 between 25 to 40km. The default values represents ozone molecules absorption in the Earth atmosphere.</summary>
	public FLinearColor OtherAbsorption;
	///<summary>Represents the altitude based tent distribution of absorption particles in the atmosphere.</summary>
	public FTentDistribution OtherTentDistribution;
	///<summary>Scales the luminance of pixels representing the sky, i.e. not belonging to any surface.</summary>
	public FLinearColor SkyLuminanceFactor;
	///<summary>Makes the aerial perspective look thicker by scaling distances from view to surfaces (opaque and translucent).</summary>
	public float AerialPespectiveViewDistanceScale;
	///<summary>Scale the sky and atmosphere lights contribution to the height fog when SupportSkyAtmosphereAffectsHeightFog project setting is true.</summary>
	public float HeightFogContribution;
	///<summary>The minimum elevation angle in degree that should be used to evaluate the sun transmittance to the ground. Useful to maintain a visible sun light and shadow on meshes even when the sun has started going below the horizon. This does not affect the aerial perspective.</summary>
	public float TransmittanceMinLightElevationAngle;
	///<summary>The distance (kilometers) at which we start evaluating the aerial perspective. Having the aerial perspective starts away from the camera can help with performance: pixels not affected by the aerial perspective will have their computation skipped using early depth test.</summary>
	public float AerialPerspectiveStartDepth;
	///<summary>OverrideAtmosphereLightDirection</summary>
	public  void OverrideAtmosphereLightDirection(int AtmosphereLightIndex,FVector LightDirection) {}
	///<summary>IsAtmosphereLightDirectionOverriden</summary>
	public  bool IsAtmosphereLightDirectionOverriden(int AtmosphereLightIndex) { return default; }
	///<summary>GetOverridenAtmosphereLightDirection</summary>
	public  FVector GetOverridenAtmosphereLightDirection(int AtmosphereLightIndex) { return default; }
	///<summary>ResetAtmosphereLightDirectionOverride</summary>
	public  void ResetAtmosphereLightDirectionOverride(int AtmosphereLightIndex) {}
	///<summary>SetAtmosphereHeight</summary>
	public  void SetAtmosphereHeight(float NewValue) {}
	///<summary>SetMultiScatteringFactor</summary>
	public  void SetMultiScatteringFactor(float NewValue) {}
	///<summary>SetRayleighScatteringScale</summary>
	public  void SetRayleighScatteringScale(float NewValue) {}
	///<summary>SetRayleighScattering</summary>
	public  void SetRayleighScattering(FLinearColor NewValue) {}
	///<summary>SetRayleighExponentialDistribution</summary>
	public  void SetRayleighExponentialDistribution(float NewValue) {}
	///<summary>SetMieScatteringScale</summary>
	public  void SetMieScatteringScale(float NewValue) {}
	///<summary>SetMieScattering</summary>
	public  void SetMieScattering(FLinearColor NewValue) {}
	///<summary>SetMieAbsorptionScale</summary>
	public  void SetMieAbsorptionScale(float NewValue) {}
	///<summary>SetMieAbsorption</summary>
	public  void SetMieAbsorption(FLinearColor NewValue) {}
	///<summary>SetMieAnisotropy</summary>
	public  void SetMieAnisotropy(float NewValue) {}
	///<summary>SetMieExponentialDistribution</summary>
	public  void SetMieExponentialDistribution(float NewValue) {}
	///<summary>SetOtherAbsorptionScale</summary>
	public  void SetOtherAbsorptionScale(float NewValue) {}
	///<summary>SetOtherAbsorption</summary>
	public  void SetOtherAbsorption(FLinearColor NewValue) {}
	///<summary>SetSkyLuminanceFactor</summary>
	public  void SetSkyLuminanceFactor(FLinearColor NewValue) {}
	///<summary>SetAerialPespectiveViewDistanceScale</summary>
	public  void SetAerialPespectiveViewDistanceScale(float NewValue) {}
	///<summary>SetHeightFogContribution</summary>
	public  void SetHeightFogContribution(float NewValue) {}
	///<summary>GetAtmosphereTransmitanceOnGroundAtPlanetTop</summary>
	public  FLinearColor GetAtmosphereTransmitanceOnGroundAtPlanetTop(UDirectionalLightComponent DirectionalLight) { return default; }
	///<summary>GUID used to associate a atmospheric component with precomputed lighting/shadowing information across levels.</summary>
	public FGuid bStaticLightingBuiltGUID;
}
