namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>LOD settings for a single texture group.</summary>
[CppInclude("Engine/TextureLODSettings.h")]
public partial struct FTextureLODGroup {
	public TextureGroup Group;
	public int LODBias;
	public int LODBias_Smaller;
	public int LODBias_Smallest;
	public int NumStreamedMips;
	public TextureMipGenSettings MipGenSettings;
	public int MinLODSize;
	public int MaxLODSize;
	public int MaxLODSize_Smaller;
	public int MaxLODSize_Smallest;
	public int MaxLODSize_VT;
	public int OptionalLODBias;
	public int OptionalMaxLODSize;
	public FName MinMagFilter;
	public FName MipFilter;
	public ETextureMipLoadOptions MipLoadOptions;
	public bool HighPriorityLoad;
	public bool DuplicateNonOptionalMips;
	public float Downscale;
	public ETextureDownscaleOptions DownscaleOptions;
	public int VirtualTextureTileCountBias;
	public int VirtualTextureTileSizeBias;
	public ETextureLossyCompressionAmount LossyCompressionAmount;
	public bool CookPlatformTilingDisabled;
}
