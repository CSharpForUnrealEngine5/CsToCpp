namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture.h")]
public partial class UTexture : UStreamableRenderAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic textures will have ! Source.IsValid()</summary>
	public FTextureSource Source;
	///<summary>Unique ID for this material, used for caching during distributed lighting</summary>
	public FGuid LightingGuid;
	///<summary>SourceFilePath_DEPRECATED</summary>
	public string SourceFilePath_DEPRECATED;
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Static texture brightness adjustment (scales HSV value.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustBrightness;
	///<summary>Static texture curve adjustment (raises HSV value to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustBrightnessCurve;
	///<summary>Static texture &quot;vibrance&quot; adjustment (0 - 1) (HSV saturation algorithm adjustment.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustVibrance;
	///<summary>Static texture saturation adjustment (scales HSV saturation.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustSaturation;
	///<summary>Static texture RGB curve adjustment (raises linear-space RGB color to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustRGBCurve;
	///<summary>Static texture hue adjustment (0 - 360) (offsets HSV hue by value in degrees.)  (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustHue;
	///<summary>Remaps the alpha to the specified min/max range, defines the new value of 0 (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustMinAlpha;
	///<summary>Remaps the alpha to the specified min/max range, defines the new value of 1 (Non-destructive; Requires texture source art to be available.)</summary>
	public float AdjustMaxAlpha;
	///<summary>If enabled, the texture&#39;s alpha channel will be forced to opaque for any compressed texture output format.  Does not apply if output format is uncompressed RGBA.</summary>
	public bool CompressionNoAlpha;
	///<summary>If true, force alpha channel in output format when possible, eg. for AutoDXT BC1/BC3 choice *</summary>
	public bool CompressionForceAlpha;
	///<summary>If true, force the texture to be uncompressed no matter the format.</summary>
	public bool CompressionNone;
	///<summary>If enabled, compress with Final quality during this Editor session.</summary>
	public bool CompressFinal;
	///<summary>If enabled, defer compression of the texture until save or manually compressed in the texture editor.</summary>
	public bool DeferCompression;
	///<summary>How aggressively should any relevant lossy compression be applied. For compressors that support EncodeSpeed (i.e. Oodle), this is only</summary>
	public ETextureLossyCompressionAmount LossyCompressionAmount;
	///<summary>Oodle Texture SDK Version to encode with.  Enter &#39;latest&#39; to update; &#39;None&#39; preserves legacy encoding to avoid patches.</summary>
	public string OodleTextureSdkVersion;
	///<summary>The maximum resolution for generated textures. A value of 0 means the maximum size for the format on each platform.</summary>
	public int MaxTextureSize;
	///<summary>The compression quality for generated ASTC textures (i.e. mobile platform textures).</summary>
	public ETextureCompressionQuality CompressionQuality;
	///<summary>Change this optional ID to force the texture to be recompressed by changing its cache key.</summary>
	public FGuid CompressionCacheId;
	///<summary>Removed.</summary>
	public bool bDitherMipMapAlpha_DEPRECATED;
	///<summary>Whether mip RGBA should be scaled to preserve the number of pixels with Value &gt;= AlphaCoverageThresholds.  AlphaCoverageThresholds are ignored if this is off.</summary>
	public bool bDoScaleMipsForAlphaCoverage;
	///<summary>Alpha values per channel to compare to when preserving alpha coverage. 0 means disable channel.  Typical good values in 0.5 - 0.9, not 1.0</summary>
	public FVector4 AlphaCoverageThresholds;
	///<summary>Use faster mip generation filter, usually the same result but occasionally causes color shift in high contrast areas.</summary>
	public bool bUseNewMipFilter;
	///<summary>When true the texture&#39;s border will be preserved during mipmap generation.</summary>
	public bool bPreserveBorder;
	///<summary>When true the texture&#39;s green channel will be inverted. This is useful for some normal maps.</summary>
	public bool bFlipGreenChannel;
	///<summary>How to pad the texture to a power of 2 size (if necessary)</summary>
	public ETexturePowerOfTwoSetting PowerOfTwoMode;
	///<summary>The color used to pad the texture out if it is resized due to PowerOfTwoMode</summary>
	public FColor PaddingColor;
	///<summary>Whether to chroma key the image, replacing any pixels that match ChromaKeyColor with transparent black</summary>
	public bool bChromaKeyTexture;
	///<summary>The threshold that components have to match for the texel to be considered equal to the ChromaKeyColor when chroma keying (&lt;=, set to 0 to require a perfect exact match)</summary>
	public float ChromaKeyThreshold;
	///<summary>The color that will be replaced with transparent black if chroma keying is enabled</summary>
	public FColor ChromaKeyColor;
	///<summary>Per asset specific setting to define the mip-map generation properties like sharpening and kernel size.</summary>
	public TextureMipGenSettings MipGenSettings;
	///<summary>Can be defined to modify the roughness based on the normal map variation (mostly from mip maps).</summary>
	public UTexture CompositeTexture;
	///<summary>defines how the CompositeTexture is applied, e.g. CTM_RoughnessFromNormalAlpha</summary>
	public ECompositeTextureMode CompositeTextureMode;
	///<summary>default 1, high values result in a stronger effect e.g 1, 2, 4, 8</summary>
	public float CompositePower;
	///<summary>Array of settings used to control the format of given layer</summary>
	public TArray<FTextureFormatSettings> LayerFormatSettings;
	///<summary>* Level scope index of this texture. It is used to reduce the amount of lookup to map a texture to its level index.</summary>
	public int LevelIndex;
	///<summary>A bias to the index of the top mip level to use.  That is, number of mip levels to drop when cooking.</summary>
	public int LODBias;
	///<summary>Compression settings to use when building the texture.</summary>
	public TextureCompressionSettings CompressionSettings;
	///<summary>The texture filtering mode to use when sampling this texture.</summary>
	public TextureFilter Filter;
	///<summary>The texture mip load options.</summary>
	public ETextureMipLoadOptions MipLoadOptions;
	///<summary>If the platform supports it, tile the texture when cooking, or keep it linear and tile it when it&#39;s actually submitted to the GPU.</summary>
	public TextureCookPlatformTilingSettings CookPlatformTilingSettings;
	///<summary>Texture group this texture belongs to</summary>
	public TextureGroup LODGroup;
	///<summary>Downscale source texture, applied only to 2d textures without mips</summary>
	public FPerPlatformFloat Downscale;
	///<summary>Texture downscaling options</summary>
	public ETextureDownscaleOptions DownscaleOptions;
	///<summary>Whether Texture and its source are in SRGB Gamma color space.  Can only be used with 8-bit and compressed formats.  This should be unchecked if using alpha channels individually as masks.</summary>
	public bool SRGB;
	///<summary>Normalize colors in Normal Maps after mip generation for better and sharper quality; recommended on if not required to match legacy behavior.</summary>
	public bool bNormalizeNormals;
	///<summary>A flag for using the simplified legacy gamma space e.g pow(color,1/2.2) for converting from FColor to FLinearColor, if we&#39;re doing sRGB.</summary>
	public bool bUseLegacyGamma;
	///<summary>Texture color management settings: source encoding and color space.</summary>
	public FTextureSourceColorSettings SourceColorSettings;
	///<summary>If true, the RHI texture will be created using TexCreate_NoTiling</summary>
	public bool bNoTiling;
	///<summary>Is this texture streamed in using VT</summary>
	public bool VirtualTextureStreaming;
	///<summary>If true the texture stores YCoCg. Blue channel will be filled with a precision scale during compression.</summary>
	public bool CompressionYCoCg;
	///<summary>If true, the RHI texture will be created without TexCreate_OfflineProcessed.</summary>
	public bool bNotOfflineProcessed;
	///<summary>Gets the memory size of the texture, in bytes.</summary>
	public long Blueprint_GetMemorySize() { return default; }
	///<summary>Gets the memory size of the texture source top mip, in bytes, and the size on disk of the asset, which may be compressed.</summary>
	public void Blueprint_GetTextureSourceDiskAndMemorySize(long OutDiskSize,long OutMemorySize) {}
	///<summary>Scan the texture source pixels to compute the min &amp; max values of the RGBA channels.</summary>
	public bool ComputeTextureSourceChannelMinMax(FLinearColor OutColorMin,FLinearColor OutColorMax) { return default; }
	///<summary>Whether the async resource release process has already been kicked off or not</summary>
	public bool bAsyncResourceReleaseHasBeenStarted;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
