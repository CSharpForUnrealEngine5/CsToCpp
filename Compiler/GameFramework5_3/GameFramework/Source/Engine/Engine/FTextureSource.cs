namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Texture source data management.</summary>
[CppInclude("Engine/Texture.h")]
public partial struct FTextureSource {
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
