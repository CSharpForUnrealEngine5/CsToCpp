#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/VolumeTexture.h")]
public partial class UVolumeTexture : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>A (optional) reference texture from which the volume texture was built</summary>
	public UTexture2D Source2DTexture;
	///<summary>SourceLightingGuid_DEPRECATED</summary>
	public FGuid SourceLightingGuid_DEPRECATED;
	///<summary>The reference texture tile size X</summary>
	public int Source2DTileSizeX;
	///<summary>The reference texture tile size Y</summary>
	public int Source2DTileSizeY;
	///<summary>The addressing mode to use for the X, Y and Z axis.</summary>
	public TextureAddress AddressMode;
}
