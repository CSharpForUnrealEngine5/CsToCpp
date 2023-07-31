#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime virtual texture UObject</summary>
[CppInclude("VT/RuntimeVirtualTexture.h")]
public partial class URuntimeVirtualTexture : UObject {
	///<summary>Size of virtual texture in tiles. (Actual values increase in powers of 2).</summary>
	public int TileCount;
	///<summary>Page tile size. (Actual values increase in powers of 2)</summary>
	public int TileSize;
	///<summary>Page tile border size divided by 2 (Actual values increase in multiples of 2). Higher values trigger a higher anisotropic sampling level.</summary>
	public int TileBorderSize;
	///<summary>Contents of virtual texture.</summary>
	public ERuntimeVirtualTextureMaterialType MaterialType;
	///<summary>Enable storing the virtual texture in GPU supported compression formats. Using uncompressed is only recommended for debugging and quality comparisons.</summary>
	public bool bCompressTextures;
	///<summary>Use low quality textures (RGB565/RGB555A1) to replace runtime compression</summary>
	public bool bUseLowQualityCompression;
	///<summary>Enable clear before rendering a page of the virtual texture. Disabling this can be an optimization if you know that the texture will always be fully covered by rendering.</summary>
	public bool bClearTextures;
	///<summary>Enable page table channel packing. This reduces page table memory and update cost but can reduce the ability to share physical memory with other virtual textures.</summary>
	public bool bSinglePhysicalSpace;
	///<summary>Enable private page table allocation. This can reduce total page table memory allocation but can also reduce the total number of virtual textures supported.</summary>
	public bool bPrivateSpace;
	///<summary>Enable sparse adaptive page tables. This supports larger tile counts but adds an indirection cost when sampling the virtual texture. It is recommended only when very large virtual resolutions are necessary.</summary>
	public bool bAdaptive;
	///<summary>Enable continuous update of the virtual texture pages. This round-robin updates already mapped pages and can help fix pages that are mapped before dependent textures are fully streamed in.</summary>
	public bool bContinuousUpdate;
	///<summary>Number of low mips to cut from the virtual texture. This can reduce peak virtual texture update cost but will also increase the probability of mip shimmering.</summary>
	public int RemoveLowMips;
	///<summary>Texture group this texture belongs to</summary>
	public TextureGroup LODGroup;
	///<summary>Deprecated size of virtual texture.</summary>
	public int Size_DEPRECATED;
	///<summary>Deprecated texture object containing streamed low mips.</summary>
	public URuntimeVirtualTextureStreamingProxy StreamingTexture_DEPRECATED;
	///<summary>Public getter for virtual texture tile count</summary>
	public  int GetTileCount() { return default; }
	///<summary>Public getter for virtual texture tile size</summary>
	public  int GetTileSize() { return default; }
	///<summary>Public getter for virtual texture tile border size</summary>
	public  int GetTileBorderSize() { return default; }
	///<summary>Public getter for virtual texture size. This is derived from the TileCount and TileSize.</summary>
	public  int GetSize() { return default; }
	///<summary>Public getter for virtual texture page table size. This is only different from GetTileCount() when using an adaptive page table.</summary>
	public  int GetPageTableSize() { return default; }
}
