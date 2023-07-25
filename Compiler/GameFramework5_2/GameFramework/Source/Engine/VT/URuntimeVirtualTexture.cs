#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VT/RuntimeVirtualTexture.h")]
///<summary>Runtime virtual texture UObject</summary>
public partial class URuntimeVirtualTexture : UObject {
// RuntimeVirtualTexture
	public int TileCount;
	public int TileSize;
	public int TileBorderSize;
	public ERuntimeVirtualTextureMaterialType MaterialType;
	public bool bCompressTextures;
	public bool bUseLowQualityCompression;
	public bool bClearTextures;
	public bool bSinglePhysicalSpace;
	public bool bPrivateSpace;
	public bool bAdaptive;
	public bool bContinuousUpdate;
	public int RemoveLowMips;
	public byte LODGroup;
	public int Size_DEPRECATED;
	public URuntimeVirtualTextureStreamingProxy StreamingTexture_DEPRECATED;
	public int GetTileCount() { return default; }
	public int GetTileSize() { return default; }
	public int GetTileBorderSize() { return default; }
	public int GetSize() { return default; }
	public int GetPageTableSize() { return default; }
}
