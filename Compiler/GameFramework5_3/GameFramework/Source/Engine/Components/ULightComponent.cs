namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LightComponent.h")]
public partial class ULightComponent : ULightComponentBase {
	public static UClass StaticClass() {return default;}
	///<summary>Color temperature in Kelvin of the blackbody illuminant.</summary>
	public float Temperature;
	///<summary>MaxDrawDistance</summary>
	public float MaxDrawDistance;
	///<summary>MaxDistanceFadeRange</summary>
	public float MaxDistanceFadeRange;
	///<summary>false: use white (D65) as illuminant.</summary>
	public bool bUseTemperature;
	///<summary>Legacy shadowmap channel from the lighting build, now stored in FLightComponentMapBuildData.</summary>
	public int ShadowMapChannel_DEPRECATED;
	///<summary>Min roughness effective for this light. Used for softening specular highlights.</summary>
	public float MinRoughness_DEPRECATED;
	///<summary>Multiplier on specular highlights. Use only with great care! Any value besides 1 is not physical!</summary>
	public float SpecularScale;
	///<summary>Scales the resolution of shadowmaps used to shadow this light.  By default shadowmap resolution is chosen based on screen size of the caster.</summary>
	public float ShadowResolutionScale;
	///<summary>Controls how accurate self shadowing of whole scene shadows from this light are.</summary>
	public float ShadowBias;
	///<summary>Controls how accurate self shadowing of whole scene shadows from this light are. This works in addition to shadow bias, by increasing the</summary>
	public float ShadowSlopeBias;
	///<summary>Amount to sharpen shadow filtering</summary>
	public float ShadowSharpen;
	///<summary>Length of screen space ray trace for sharp contact shadows. Zero is disabled.</summary>
	public float ContactShadowLength;
	///<summary>Where Length of screen space ray trace for sharp contact shadows is in world space units or in screen space units.</summary>
	public bool ContactShadowLengthInWS;
	///<summary>Intensity of the shadows cast by primitives with &quot;cast contact shadow&quot; enabled. 0 = no shadow, 1 (default) = fully shadowed.</summary>
	public float ContactShadowCastingIntensity;
	///<summary>Intensity of the shadows cast by primitives with &quot;cast contact shadow&quot; disabled. 0 (default) = no shadow, 1 = fully shadowed.</summary>
	public float ContactShadowNonCastingIntensity;
	///<summary>InverseSquaredFalloff_DEPRECATED</summary>
	public bool InverseSquaredFalloff_DEPRECATED;
	///<summary>Whether the light is allowed to cast dynamic shadows from translucency.</summary>
	public bool CastTranslucentShadows;
	///<summary>Whether the light should only cast shadows from components marked as bCastCinematicShadows.</summary>
	public bool bCastShadowsFromCinematicObjectsOnly;
	///<summary>Enables cached shadows for movable primitives for this light even if r.shadow.cachedshadowscastfrommovableprimitives is 0</summary>
	public bool bForceCachedShadowsForMovablePrimitives;
	///<summary>Channels that this light should affect.</summary>
	public FLightingChannels LightingChannels;
	///<summary>The light function material to be applied to this light.</summary>
	public UMaterialInterface LightFunctionMaterial;
	///<summary>When clearing the light func, e.g. because the light is made static, this field remembers the last value</summary>
	public UMaterialInterface StashedLightFunctionMaterial;
	///<summary>Scales the light function projection.  X and Y scale in the directions perpendicular to the light&#39;s direction, Z scales along the light direction.</summary>
	public FVector LightFunctionScale;
	///<summary>IES texture (light profiles from real world measured data)</summary>
	public UTextureLightProfile IESTexture;
	///<summary>true: take light brightness from IES profile, false: use the light brightness - the maximum light in one direction is used to define no masking. Use with InverseSquareFalloff. Will be disabled if a valid IES profile texture is not supplied.</summary>
	public bool bUseIESBrightness;
	///<summary>Global scale for IES brightness contribution. Only available when &quot;Use IES Brightness&quot; is selected, and a valid IES profile texture is set</summary>
	public float IESBrightnessScale;
	///<summary>Distance at which the light function should be completely faded to DisabledBrightness.</summary>
	public float LightFunctionFadeDistance;
	///<summary>Brightness factor applied to the light when the light function is specified but disabled, for example in scene captures that use SceneCapView_LitNoShadows.</summary>
	public float DisabledBrightness;
	///<summary>Whether to render light shaft bloom from this light.</summary>
	public bool bEnableLightShaftBloom;
	///<summary>Scales the additive color.</summary>
	public float BloomScale;
	///<summary>Scene color must be larger than this to create bloom in the light shafts.</summary>
	public float BloomThreshold;
	///<summary>After exposure is applied, scene color brightness larger than BloomMaxBrightness will be rescaled down to BloomMaxBrightness.</summary>
	public float BloomMaxBrightness;
	///<summary>Multiplies against scene color to create the bloom color.</summary>
	public FColor BloomTint;
	///<summary>Whether to use ray traced distance field area shadows.  The project setting bGenerateMeshDistanceFields must be enabled for this to have effect.</summary>
	public bool bUseRayTracedDistanceFieldShadows;
	///<summary>Controls how large of an offset ray traced shadows have from the receiving surface as the camera gets further away.</summary>
	public float RayStartOffsetDepthScale;
	///<summary>Set intensity of the light</summary>
	public void SetIntensity(float NewIntensity) {}
	///<summary>SetIndirectLightingIntensity</summary>
	public void SetIndirectLightingIntensity(float NewIntensity) {}
	///<summary>SetVolumetricScatteringIntensity</summary>
	public void SetVolumetricScatteringIntensity(float NewIntensity) {}
	///<summary>Set color of the light</summary>
	public void SetLightColor(FLinearColor NewLightColor,bool bSRGB/*=true*/) {}
	///<summary>Set color of the light</summary>
	public void SetLightFColor(FColor NewLightColor) {}
	///<summary>SetTemperature</summary>
	public void SetTemperature(float NewTemperature) {}
	///<summary>SetUseTemperature</summary>
	public void SetUseTemperature(bool bNewValue) {}
	///<summary>SetLightFunctionMaterial</summary>
	public void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial) {}
	///<summary>SetLightFunctionScale</summary>
	public void SetLightFunctionScale(FVector NewLightFunctionScale) {}
	///<summary>SetLightFunctionFadeDistance</summary>
	public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance) {}
	///<summary>SetLightFunctionDisabledBrightness</summary>
	public void SetLightFunctionDisabledBrightness(float NewValue) {}
	///<summary>SetAffectTranslucentLighting</summary>
	public void SetAffectTranslucentLighting(bool bNewValue) {}
	///<summary>SetTransmission</summary>
	public void SetTransmission(bool bNewValue) {}
	///<summary>SetEnableLightShaftBloom</summary>
	public void SetEnableLightShaftBloom(bool bNewValue) {}
	///<summary>SetBloomScale</summary>
	public void SetBloomScale(float NewValue) {}
	///<summary>SetBloomThreshold</summary>
	public void SetBloomThreshold(float NewValue) {}
	///<summary>SetBloomMaxBrightness</summary>
	public void SetBloomMaxBrightness(float NewValue) {}
	///<summary>SetBloomTint</summary>
	public void SetBloomTint(FColor NewValue) {}
	///<summary>SetIESTexture</summary>
	public void SetIESTexture(UTextureLightProfile NewValue) {}
	///<summary>SetUseIESBrightness</summary>
	public void SetUseIESBrightness(bool bNewValue) {}
	///<summary>SetIESBrightnessScale</summary>
	public void SetIESBrightnessScale(float NewValue) {}
	///<summary>SetShadowBias</summary>
	public void SetShadowBias(float NewValue) {}
	///<summary>SetShadowSlopeBias</summary>
	public void SetShadowSlopeBias(float NewValue) {}
	///<summary>SetSpecularScale</summary>
	public void SetSpecularScale(float NewValue) {}
	///<summary>SetForceCachedShadowsForMovablePrimitives</summary>
	public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue) {}
	///<summary>SetLightingChannels</summary>
	public void SetLightingChannels(bool bChannel0,bool bChannel1,bool bChannel2) {}
}
