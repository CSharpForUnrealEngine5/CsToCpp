#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to create fogging effects such as clouds but with a density that is related to the height of the fog.</summary>
[CppInclude("Components/ExponentialHeightFogComponent.h")]
public partial class UExponentialHeightFogComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Global density factor.</summary>
	public float FogDensity;
	///<summary>Height density factor, controls how the density increases as height decreases.</summary>
	public float FogHeightFalloff;
	///<summary>Settings for the second fog. Setting the density of this to 0 means it doesn&#39;t have any influence.</summary>
	public FExponentialHeightFogData SecondFogData;
	///<summary>FogInscatteringColor_DEPRECATED</summary>
	public FLinearColor FogInscatteringColor_DEPRECATED;
	///<summary>FogInscatteringLuminance</summary>
	public FLinearColor FogInscatteringLuminance;
	///<summary>Color used to modulate the SkyAtmosphere component contribution to the non directional component of the fog. Only effective when r.SupportSkyAtmosphereAffectsHeightFog&gt;0</summary>
	public FLinearColor SkyAtmosphereAmbientContributionColorScale;
	///<summary>Cubemap that can be specified for fog color, which is useful to make distant, heavily fogged scene elements match the sky.</summary>
	public UTextureCube InscatteringColorCubemap;
	///<summary>Angle to rotate the InscatteringColorCubemap around the Z axis.</summary>
	public float InscatteringColorCubemapAngle;
	///<summary>Tint color used when InscatteringColorCubemap is specified, for quick edits without having to reimport InscatteringColorCubemap.</summary>
	public FLinearColor InscatteringTextureTint;
	///<summary>Distance at which InscatteringColorCubemap should be used directly for the Inscattering Color.</summary>
	public float FullyDirectionalInscatteringColorDistance;
	///<summary>Distance at which only the average color of InscatteringColorCubemap should be used as Inscattering Color.</summary>
	public float NonDirectionalInscatteringColorDistance;
	///<summary>Controls the size of the directional inscattering cone, which is used to approximate inscattering from a directional light.</summary>
	public float DirectionalInscatteringExponent;
	///<summary>Controls the start distance from the viewer of the directional inscattering, which is used to approximate inscattering from a directional light.</summary>
	public float DirectionalInscatteringStartDistance;
	///<summary>DirectionalInscatteringColor_DEPRECATED</summary>
	public FLinearColor DirectionalInscatteringColor_DEPRECATED;
	///<summary>Controls the color of the directional inscattering, which is used to approximate inscattering from a directional light.</summary>
	public FLinearColor DirectionalInscatteringLuminance;
	///<summary>Maximum opacity of the fog.</summary>
	public float FogMaxOpacity;
	///<summary>Distance from the camera that the fog will start, in world units.</summary>
	public float StartDistance;
	///<summary>Scene elements past this distance will not have fog applied.  This is useful for excluding skyboxes which already have fog baked in.</summary>
	public float FogCutoffDistance;
	///<summary>Whether to enable Volumetric fog.  Scalability settings control the resolution of the fog simulation.</summary>
	public bool bEnableVolumetricFog;
	///<summary>Controls the scattering phase function - how much incoming light scatters in various directions.</summary>
	public float VolumetricFogScatteringDistribution;
	///<summary>The height fog particle reflectiveness used by volumetric fog.</summary>
	public FColor VolumetricFogAlbedo;
	///<summary>Light emitted by height fog.  This is a density so more light is emitted the further you are looking through the fog.</summary>
	public FLinearColor VolumetricFogEmissive;
	///<summary>Scales the height fog particle extinction amount used by volumetric fog.  Values larger than 1 cause fog particles everywhere absorb more light.</summary>
	public float VolumetricFogExtinctionScale;
	///<summary>Distance over which volumetric fog should be computed, after the start distance.  Larger values extend the effect into the distance but expose under-sampling artifacts in details.</summary>
	public float VolumetricFogDistance;
	///<summary>Distance from the camera that the volumetric fog will start, in world units.</summary>
	public float VolumetricFogStartDistance;
	///<summary>Distance over which volumetric fog will fade in from the start distance.</summary>
	public float VolumetricFogNearFadeInDistance;
	///<summary>VolumetricFogStaticLightingScatteringIntensity</summary>
	public float VolumetricFogStaticLightingScatteringIntensity;
	///<summary>Whether to use FogInscatteringColor for the Sky Light volumetric scattering color and DirectionalInscatteringColor for the Directional Light scattering color.</summary>
	public bool bOverrideLightColorsWithFogInscatteringColors;
	///<summary>SetFogDensity</summary>
	public  void SetFogDensity(float Value) {}
	///<summary>SetSecondFogDensity</summary>
	public  void SetSecondFogDensity(float Value) {}
	///<summary>SetFogInscatteringColor</summary>
	public  void SetFogInscatteringColor(FLinearColor Value) {}
	///<summary>SetInscatteringColorCubemap</summary>
	public  void SetInscatteringColorCubemap(UTextureCube Value) {}
	///<summary>SetInscatteringColorCubemapAngle</summary>
	public  void SetInscatteringColorCubemapAngle(float Value) {}
	///<summary>SetFullyDirectionalInscatteringColorDistance</summary>
	public  void SetFullyDirectionalInscatteringColorDistance(float Value) {}
	///<summary>SetNonDirectionalInscatteringColorDistance</summary>
	public  void SetNonDirectionalInscatteringColorDistance(float Value) {}
	///<summary>SetInscatteringTextureTint</summary>
	public  void SetInscatteringTextureTint(FLinearColor Value) {}
	///<summary>SetDirectionalInscatteringExponent</summary>
	public  void SetDirectionalInscatteringExponent(float Value) {}
	///<summary>SetDirectionalInscatteringStartDistance</summary>
	public  void SetDirectionalInscatteringStartDistance(float Value) {}
	///<summary>SetDirectionalInscatteringColor</summary>
	public  void SetDirectionalInscatteringColor(FLinearColor Value) {}
	///<summary>SetSecondFogHeightOffset</summary>
	public  void SetSecondFogHeightOffset(float Value) {}
	///<summary>SetFogHeightFalloff</summary>
	public  void SetFogHeightFalloff(float Value) {}
	///<summary>SetSecondFogHeightFalloff</summary>
	public  void SetSecondFogHeightFalloff(float Value) {}
	///<summary>SetFogMaxOpacity</summary>
	public  void SetFogMaxOpacity(float Value) {}
	///<summary>SetStartDistance</summary>
	public  void SetStartDistance(float Value) {}
	///<summary>SetFogCutoffDistance</summary>
	public  void SetFogCutoffDistance(float Value) {}
	///<summary>SetVolumetricFog</summary>
	public  void SetVolumetricFog(bool bNewValue) {}
	///<summary>SetVolumetricFogScatteringDistribution</summary>
	public  void SetVolumetricFogScatteringDistribution(float NewValue) {}
	///<summary>SetVolumetricFogExtinctionScale</summary>
	public  void SetVolumetricFogExtinctionScale(float NewValue) {}
	///<summary>SetVolumetricFogAlbedo</summary>
	public  void SetVolumetricFogAlbedo(FColor NewValue) {}
	///<summary>SetVolumetricFogEmissive</summary>
	public  void SetVolumetricFogEmissive(FLinearColor NewValue) {}
	///<summary>SetVolumetricFogDistance</summary>
	public  void SetVolumetricFogDistance(float NewValue) {}
	///<summary>SetSecondFogData</summary>
	public  void SetSecondFogData(FExponentialHeightFogData NewValue) {}
}
