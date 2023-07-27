#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture.h")]
///<summary>Texture source data management.</summary>
public partial struct FTextureSource {
// TextureSource
	public FGuid Id;
	public int BaseBlockX;
	public int BaseBlockY;
	public int SizeX;
	public int SizeY;
	public int NumSlices;
	public int NumMips;
	public int NumLayers;
	public bool bPNGCompressed_DEPRECATED;
	public bool bLongLatCubemap;
	public ETextureSourceCompressionFormat CompressionFormat;
	public bool bGuidIsHash;
	public ETextureSourceFormat Format;
	public TArray<ETextureSourceFormat> LayerFormat;
	public TArray<FTextureSourceBlock> Blocks;
	public TArray<long> BlockDataOffsets;
}
