#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LightComponentBase.h")]
public partial class ULightComponentBase : USceneComponent {
// LightComponentBase
	public FGuid LightGuid;
	public float Brightness_DEPRECATED;
	public float Intensity;
	public FColor LightColor;
	public bool bAffectsWorld;
	public bool CastShadows;
	public bool CastStaticShadows;
	public bool CastDynamicShadows;
	public bool bAffectTranslucentLighting;
	public bool bTransmission;
	public bool bCastVolumetricShadow;
	public bool bCastDeepShadow;
	public bool bCastRaytracedShadow_DEPRECATED;
	public ECastRayTracedShadow CastRaytracedShadow;
	public bool bAffectReflection;
	public bool bAffectGlobalIllumination;
	public float DeepShadowLayerDistribution;
	public float IndirectLightingIntensity;
	public float VolumetricScatteringIntensity;
	public int SamplesPerPixel;
	public UTexture2D StaticEditorTexture;
	public float StaticEditorTextureScale;
	public UTexture2D DynamicEditorTexture;
	public float DynamicEditorTextureScale;
	public  void SetCastShadows(bool bNewValue) {}
	public  FLinearColor GetLightColor() { return default; }
	public  void SetCastVolumetricShadow(bool bNewValue) {}
	public  void SetCastDeepShadow(bool bNewValue) {}
	public  void SetAffectReflection(bool bNewValue) {}
	public  void SetAffectGlobalIllumination(bool bNewValue) {}
	public  void SetCastRaytracedShadow(bool bNewValue) {}
	public  void SetCastRaytracedShadows(ECastRayTracedShadow bNewValue) {}
	public  void SetSamplesPerPixel(int NewValue) {}
}
