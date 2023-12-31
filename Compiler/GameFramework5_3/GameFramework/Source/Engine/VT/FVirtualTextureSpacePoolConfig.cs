namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings of a single pool</summary>
[CppInclude("VT/VirtualTexturePoolConfig.h")]
public partial struct FVirtualTextureSpacePoolConfig {
	public int MinTileSize;
	public int MaxTileSize;
	public TArray<EPixelFormat> Formats;
	public int SizeInMegabyte;
	public bool bEnableResidencyMipMapBias;
	public bool bAllowSizeScale;
	public uint ScalabilityGroup;
	public int MinScaledSizeInMegabyte;
	public int MaxScaledSizeInMegabyte;
}
