#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureLODSettings.h")]
///<summary>LOD settings for a single texture group.</summary>
public partial struct FTextureLODGroup {
// TextureLODGroup
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
	public string MinMagFilter;
	public string MipFilter;
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
