#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/VolumeTexture.h")]
public partial class UVolumeTexture : UTexture {
// VolumeTexture
	public UTexture2D Source2DTexture;
	public FGuid SourceLightingGuid_DEPRECATED;
	public int Source2DTileSizeX;
	public int Source2DTileSizeY;
	public byte AddressMode;
}
