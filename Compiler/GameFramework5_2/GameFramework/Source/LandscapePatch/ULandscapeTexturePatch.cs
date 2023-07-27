#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTexturePatch.h")]
public partial class ULandscapeTexturePatch : ULandscapePatchComponent {
// LandscapeTexturePatch
	public  FTransform GetPatchToWorldTransform() { return default; }
	public  FVector2D GetUnscaledCoverage() { return default; }
	public  void SetUnscaledCoverage(FVector2D Coverage) {}
	public  FVector2D GetFullUnscaledWorldSize() { return default; }
	public  FVector2D GetResolution() { return default; }
	public  void SetResolution(FVector2D ResolutionIn) {}
	public  bool GetInitResolutionFromLandscape(float ResolutionMultiplier,FVector2D ResolutionOut) { return default; }
	public  void SetFalloff(float FalloffIn) {}
	public  void SetBlendMode(ELandscapeTexturePatchBlendMode BlendModeIn) {}
	public  ELandscapeTexturePatchSourceMode GetHeightSourceMode() { return default; }
	public  void SetHeightSourceMode(ELandscapeTexturePatchSourceMode NewMode) {}
	public  void SetHeightTextureAsset(UTexture TextureIn) {}
	public  UTextureRenderTarget2D GetHeightRenderTarget() { return default; }
	public  void SetHeightRenderTargetFormat(ETextureRenderTargetFormat Format) {}
	public  void SetUseAlphaChannelForHeight(bool bUse) {}
	public  void SetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	public  void ResetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	public  void SetHeightEncodingSettings(FLandscapeTexturePatchEncodingSettings Settings) {}
	public  void SetZeroHeightMeaning(ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaningIn) {}
	public  void AddWeightPatch(string InWeightmapLayerName,ELandscapeTexturePatchSourceMode SourceMode,bool bUseAlphaChannel) {}
	public  void RemoveWeightPatch(string InWeightmapLayerName) {}
	public  void RemoveAllWeightPatches() {}
	public  void DisableAllWeightPatches() {}
	public  TArray<string> GetAllWeightPatchLayerNames() { return default; }
	public  ELandscapeTexturePatchSourceMode GetWeightPatchSourceMode(string InWeightmapLayerName) { return default; }
	public  void SetWeightPatchSourceMode(string InWeightmapLayerName,ELandscapeTexturePatchSourceMode NewMode) {}
	public  void SetWeightPatchTextureAsset(string InWeightmapLayerName,UTexture TextureIn) {}
	public  UTextureRenderTarget2D GetWeightPatchRenderTarget(string InWeightmapLayerName) { return default; }
	public  void SetUseAlphaChannelForWeightPatch(string InWeightmapLayerName,bool bUseAlphaChannel) {}
	public  void SetWeightPatchBlendModeOverride(string InWeightmapLayerName,ELandscapeTexturePatchBlendMode BlendMode) {}
	public  void ClearWeightPatchBlendModeOverride(string InWeightmapLayerName) {}
	public int ResolutionX;
	public int ResolutionY;
	public FVector2D UnscaledPatchCoverage;
	public ELandscapeTexturePatchBlendMode BlendMode;
	public ELandscapeTexturePatchFalloffMode FalloffMode;
	public float Falloff;
	public ELandscapeTexturePatchSourceMode HeightSourceMode;
	public ELandscapeTexturePatchSourceMode DetailPanelHeightSourceMode;
	public ULandscapeHeightTextureBackedRenderTarget HeightInternalData;
	public UTexture HeightTextureAsset;
	public bool bUseTextureAlphaForHeight;
	public ELandscapeTextureHeightPatchEncoding HeightEncoding;
	public FLandscapeTexturePatchEncodingSettings HeightEncodingSettings;
	public ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaning;
	public bool bApplyComponentZScale;
	public TArray<ULandscapeWeightPatchTextureInfo> WeightPatches;
	public int NumWeightPatches;
	public  void ReinitializeHeight() {}
	public  void ReinitializeWeights() {}
	public  void SnapToLandscape() {}
	public bool bBaseResolutionOffLandscape;
	public float ResolutionMultiplier;
	public int InitTextureSizeX;
	public int InitTextureSizeY;
	public ETextureRenderTargetFormat HeightRenderTargetFormat;
}
