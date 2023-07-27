#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture.h")]
public partial class UTexture : UStreamableRenderAsset {
// Texture
	public FTextureSource Source;
	public FGuid LightingGuid;
	public string SourceFilePath_DEPRECATED;
	public UAssetImportData AssetImportData;
	public float AdjustBrightness;
	public float AdjustBrightnessCurve;
	public float AdjustVibrance;
	public float AdjustSaturation;
	public float AdjustRGBCurve;
	public float AdjustHue;
	public float AdjustMinAlpha;
	public float AdjustMaxAlpha;
	public bool CompressionNoAlpha;
	public bool CompressionForceAlpha;
	public bool CompressionNone;
	public bool CompressFinal;
	public bool DeferCompression;
	public byte LossyCompressionAmount;
	public string OodleTextureSdkVersion;
	public int MaxTextureSize;
	public byte CompressionQuality;
	public FGuid CompressionCacheId;
	public bool bDitherMipMapAlpha_DEPRECATED;
	public bool bDoScaleMipsForAlphaCoverage;
	public FVector4 AlphaCoverageThresholds;
	public bool bUseNewMipFilter;
	public bool bPreserveBorder;
	public bool bFlipGreenChannel;
	public byte PowerOfTwoMode;
	public FColor PaddingColor;
	public bool bChromaKeyTexture;
	public float ChromaKeyThreshold;
	public FColor ChromaKeyColor;
	public byte MipGenSettings;
	public UTexture CompositeTexture;
	public byte CompositeTextureMode;
	public float CompositePower;
	public TArray<FTextureFormatSettings> LayerFormatSettings;
	public int LevelIndex;
	public int LODBias;
	public byte CompressionSettings;
	public byte Filter;
	public ETextureMipLoadOptions MipLoadOptions;
	public byte CookPlatformTilingSettings;
	public byte LODGroup;
	public FPerPlatformFloat Downscale;
	public ETextureDownscaleOptions DownscaleOptions;
	public bool SRGB;
	public bool bNormalizeNormals;
	public bool bUseLegacyGamma;
	public FTextureSourceColorSettings SourceColorSettings;
	public bool bNoTiling;
	public bool VirtualTextureStreaming;
	public bool CompressionYCoCg;
	public bool bNotOfflineProcessed;
	public  long Blueprint_GetMemorySize() { return default; }
	public  void Blueprint_GetTextureSourceDiskAndMemorySize(long OutDiskSize,long OutMemorySize) {}
	public  bool ComputeTextureSourceChannelMinMax(FLinearColor OutColorMin,FLinearColor OutColorMax) { return default; }
	public bool bAsyncResourceReleaseHasBeenStarted;
	public TArray<UAssetUserData> AssetUserData;
}
