#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeTexturePatch.h")]
public partial class ULandscapeTexturePatch : ULandscapePatchComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the transform from patch to world. The transform is based off of the component</summary>
	public  FTransform GetPatchToWorldTransform() { return default; }
	///<summary>Gives size in unscaled world coordinates (ie before applying patch transform) of the patch as measured</summary>
	public  FVector2D GetUnscaledCoverage() { return default; }
	///<summary>Set the patch coverage (see GetUnscaledCoverage for description).</summary>
	public  void SetUnscaledCoverage(FVector2D Coverage) {}
	///<summary>Gives size in unscaled world coordinates of the patch in the world, based off of UnscaledCoverage and</summary>
	public  FVector2D GetFullUnscaledWorldSize() { return default; }
	///<summary>Gets the size (in pixels) of the internal textures used by the patch. Does not reflect the resolution</summary>
	public  FVector2D GetResolution() { return default; }
	///<summary>Sets the resolution of the currently used internal texture or render target. Has no effect</summary>
	public  void SetResolution(FVector2D ResolutionIn) {}
	///<summary>Given the landscape resolution, current patch coverage, and a landscape resolution multiplier, gives the</summary>
	public  bool GetInitResolutionFromLandscape(float ResolutionMultiplier,FVector2D ResolutionOut) { return default; }
	///<summary>SetFalloff</summary>
	public  void SetFalloff(float FalloffIn) {}
	///<summary>SetBlendMode</summary>
	public  void SetBlendMode(ELandscapeTexturePatchBlendMode BlendModeIn) {}
	///<summary>Height related functions:</summary>
	public  ELandscapeTexturePatchSourceMode GetHeightSourceMode() { return default; }
	///<summary>Changes source mode. When changing between sources, existing data is copied from one to the other</summary>
	public  void SetHeightSourceMode(ELandscapeTexturePatchSourceMode NewMode) {}
	///<summary>Sets the texture used for height when the height source mode is set to texture asset. Note that</summary>
	public  void SetHeightTextureAsset(UTexture TextureIn) {}
	///<summary>GetHeightRenderTarget</summary>
	public  UTextureRenderTarget2D GetHeightRenderTarget() { return default; }
	///<summary>SetHeightRenderTargetFormat</summary>
	public  void SetHeightRenderTargetFormat(ETextureRenderTargetFormat Format) {}
	///<summary>SetUseAlphaChannelForHeight</summary>
	public  void SetUseAlphaChannelForHeight(bool bUse) {}
	///<summary>Set the height encoding mode for the patch, which determines how stored values in the patch</summary>
	public  void SetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	///<summary>Just like SetSourceEncodingMode, but resets ZeroInEncoding and WorldSpaceEncodingScale to mode-specific defaults.</summary>
	public  void ResetHeightEncodingMode(ELandscapeTextureHeightPatchEncoding EncodingMode) {}
	///<summary>Set settings that determine how values in the patch are translated into heights. This is only</summary>
	public  void SetHeightEncodingSettings(FLandscapeTexturePatchEncodingSettings Settings) {}
	///<summary>Set how zero height is interpreted, see comments in ELandscapeTextureHeightPatchZeroHeightMeaning.</summary>
	public  void SetZeroHeightMeaning(ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaningIn) {}
	///<summary>By default, the layer is added with source mode set to be a texture-backed render target.</summary>
	public  void AddWeightPatch(string InWeightmapLayerName,ELandscapeTexturePatchSourceMode SourceMode,bool bUseAlphaChannel) {}
	///<summary>RemoveWeightPatch</summary>
	public  void RemoveWeightPatch(string InWeightmapLayerName) {}
	///<summary>RemoveAllWeightPatches</summary>
	public  void RemoveAllWeightPatches() {}
	///<summary>Sets the soure mode of all weight patches to &quot;None&quot;.</summary>
	public  void DisableAllWeightPatches() {}
	///<summary>GetAllWeightPatchLayerNames</summary>
	public  TArray<string> GetAllWeightPatchLayerNames() { return default; }
	///<summary>GetWeightPatchSourceMode</summary>
	public  ELandscapeTexturePatchSourceMode GetWeightPatchSourceMode(string InWeightmapLayerName) { return default; }
	///<summary>SetWeightPatchSourceMode</summary>
	public  void SetWeightPatchSourceMode(string InWeightmapLayerName,ELandscapeTexturePatchSourceMode NewMode) {}
	///<summary>SetWeightPatchTextureAsset</summary>
	public  void SetWeightPatchTextureAsset(string InWeightmapLayerName,UTexture TextureIn) {}
	///<summary>GetWeightPatchRenderTarget</summary>
	public  UTextureRenderTarget2D GetWeightPatchRenderTarget(string InWeightmapLayerName) { return default; }
	///<summary>SetUseAlphaChannelForWeightPatch</summary>
	public  void SetUseAlphaChannelForWeightPatch(string InWeightmapLayerName,bool bUseAlphaChannel) {}
	///<summary>SetWeightPatchBlendModeOverride</summary>
	public  void SetWeightPatchBlendModeOverride(string InWeightmapLayerName,ELandscapeTexturePatchBlendMode BlendMode) {}
	///<summary>ClearWeightPatchBlendModeOverride</summary>
	public  void ClearWeightPatchBlendModeOverride(string InWeightmapLayerName) {}
	///<summary>ResolutionX</summary>
	public int ResolutionX;
	///<summary>ResolutionY</summary>
	public int ResolutionY;
	///<summary>At scale 1.0, the X and Y of the region affected by the height patch. This corresponds to the distance from the center</summary>
	public FVector2D UnscaledPatchCoverage;
	///<summary>BlendMode</summary>
	public ELandscapeTexturePatchBlendMode BlendMode;
	///<summary>FalloffMode</summary>
	public ELandscapeTexturePatchFalloffMode FalloffMode;
	///<summary>Distance (in unscaled world coordinates) across which to smoothly fall off the patch effects.</summary>
	public float Falloff;
	///<summary>How the heightmap of the patch is stored. This is the property that is actually used, and it will</summary>
	public ELandscapeTexturePatchSourceMode HeightSourceMode;
	///<summary>How the heightmap of the patch is stored. Not settable in the detail panel of the blueprint editor- use SetHeightSourceMode</summary>
	public ELandscapeTexturePatchSourceMode DetailPanelHeightSourceMode;
	///<summary>Not directly settable via detail panel- for display/debugging purposes only.</summary>
	public ULandscapeHeightTextureBackedRenderTarget HeightInternalData;
	///<summary>Texture used when source mode is set to a texture asset.</summary>
	public UTexture HeightTextureAsset;
	///<summary>When true, texture alpha channel will be used when applying the patch.</summary>
	public bool bUseTextureAlphaForHeight;
	///<summary>How the values stored in the patch represent the height. Not customizable for Internal Texture source mode, which always uses native packed height.</summary>
	public ELandscapeTextureHeightPatchEncoding HeightEncoding;
	///<summary>Encoding settings. Not relevant when using native packed height as the encoding.</summary>
	public FLandscapeTexturePatchEncodingSettings HeightEncodingSettings;
	///<summary>How 0 height is interpreted.</summary>
	public ELandscapeTextureHeightPatchZeroHeightMeaning ZeroHeightMeaning;
	///<summary>Whether to apply the patch Z scale to the height stored in the patch.</summary>
	public bool bApplyComponentZScale;
	///<summary>WeightPatches</summary>
	public TArray<ULandscapeWeightPatchTextureInfo> WeightPatches;
	///<summary>Used to detect changes to the number of weight patches via the detail panel, so that we can</summary>
	public int NumWeightPatches;
	///<summary>Given the current initialization settings, reinitialize the height patch.</summary>
	public  void ReinitializeHeight() {}
	///<summary>ReinitializeWeights</summary>
	public  void ReinitializeWeights() {}
	///<summary>Adjusts patch rotation to be aligned to a 90 degree increment relative to the landscape,</summary>
	public  void SnapToLandscape() {}
	///<summary>When initializing from landscape, set resolution based off of the landscape (and a multiplier).</summary>
	public bool bBaseResolutionOffLandscape;
	///<summary>Multiplier to apply to landscape resolution when initializing patch resolution. A value greater than 1.0 will use higher</summary>
	public float ResolutionMultiplier;
	///<summary>Texture width to use when reinitializing, if not basing resolution off landscape.</summary>
	public int InitTextureSizeX;
	///<summary>Texture height to use when reinitializing</summary>
	public int InitTextureSizeY;
	///<summary>HeightRenderTargetFormat</summary>
	public ETextureRenderTargetFormat HeightRenderTargetFormat;
}
