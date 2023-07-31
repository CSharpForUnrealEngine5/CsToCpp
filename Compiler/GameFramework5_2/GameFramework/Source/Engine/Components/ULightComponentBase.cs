#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LightComponentBase.h")]
public partial class ULightComponentBase : USceneComponent {
	///<summary>GUID used to associate a light component with precomputed shadowing information across levels.</summary>
	public FGuid LightGuid;
	///<summary>Brightness_DEPRECATED</summary>
	public float Brightness_DEPRECATED;
	///<summary>Total energy that the light emits.</summary>
	public float Intensity;
	///<summary>Filter color of the light.</summary>
	public FColor LightColor;
	///<summary>Whether the light can affect the world, or whether it is disabled.</summary>
	public bool bAffectsWorld;
	///<summary>Whether the light should cast any shadows.</summary>
	public bool CastShadows;
	///<summary>Whether the light should cast shadows from static objects.  Also requires Cast Shadows to be set to True.</summary>
	public bool CastStaticShadows;
	///<summary>Whether the light should cast shadows from dynamic objects.  Also requires Cast Shadows to be set to True.</summary>
	public bool CastDynamicShadows;
	///<summary>Whether the light affects translucency or not.  Disabling this can save GPU time when there are many small lights.</summary>
	public bool bAffectTranslucentLighting;
	///<summary>Whether light from this light transmits through surfaces with subsurface scattering profiles. Requires light to be movable.</summary>
	public bool bTransmission;
	///<summary>Whether the light shadows volumetric fog.  Disabling this can save GPU time.</summary>
	public bool bCastVolumetricShadow;
	///<summary>Whether the light should cast high quality hair-strands self-shadowing. When this option is enabled, an extra GPU cost for this light.</summary>
	public bool bCastDeepShadow;
	///<summary>Whether the light shadows are computed with shadow-mapping or ray-tracing (when available).</summary>
	public bool bCastRaytracedShadow_DEPRECATED;
	///<summary>CastRaytracedShadow</summary>
	public ECastRayTracedShadow CastRaytracedShadow;
	///<summary>Whether the light affects objects in reflections, when ray-traced reflection is enabled.</summary>
	public bool bAffectReflection;
	///<summary>Whether the light affects global illumination, when ray-traced global illumination is enabled.</summary>
	public bool bAffectGlobalIllumination;
	///<summary>Change the deep shadow layers distribution 0:linear distribution (uniform layer distribution), 1:exponential (more details on near small details).</summary>
	public float DeepShadowLayerDistribution;
	///<summary>Scales the indirect lighting contribution from this light.</summary>
	public float IndirectLightingIntensity;
	///<summary>Intensity of the volumetric scattering from this light.  This scales Intensity and LightColor.</summary>
	public float VolumetricScatteringIntensity;
	///<summary>Samples per pixel for ray tracing</summary>
	public int SamplesPerPixel;
	///<summary>Sprite for static light in the editor.</summary>
	public UTexture2D StaticEditorTexture;
	///<summary>Sprite scaling for static light in the editor.</summary>
	public float StaticEditorTextureScale;
	///<summary>Sprite for dynamic light in the editor.</summary>
	public UTexture2D DynamicEditorTexture;
	///<summary>Sprite scaling for dynamic light in the editor.</summary>
	public float DynamicEditorTextureScale;
	///<summary>Sets whether this light casts shadows</summary>
	public  void SetCastShadows(bool bNewValue) {}
	///<summary>Gets the light color as a linear color</summary>
	public  FLinearColor GetLightColor() { return default; }
	///<summary>SetCastVolumetricShadow</summary>
	public  void SetCastVolumetricShadow(bool bNewValue) {}
	///<summary>SetCastDeepShadow</summary>
	public  void SetCastDeepShadow(bool bNewValue) {}
	///<summary>SetAffectReflection</summary>
	public  void SetAffectReflection(bool bNewValue) {}
	///<summary>SetAffectGlobalIllumination</summary>
	public  void SetAffectGlobalIllumination(bool bNewValue) {}
	///<summary>SetCastRaytracedShadow</summary>
	public  void SetCastRaytracedShadow(bool bNewValue) {}
	///<summary>SetCastRaytracedShadows</summary>
	public  void SetCastRaytracedShadows(ECastRayTracedShadow bNewValue) {}
	///<summary>SetSamplesPerPixel</summary>
	public  void SetSamplesPerPixel(int NewValue) {}
}
