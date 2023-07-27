#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VT/VirtualTexturePoolConfig.h")]
///<summary>Settings of a single pool</summary>
public partial struct FVirtualTextureSpacePoolConfig {
// VirtualTextureSpacePoolConfig
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
