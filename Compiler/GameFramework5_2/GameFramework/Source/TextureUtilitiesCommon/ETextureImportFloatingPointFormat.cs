#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureImportSettings.h")]
///<summary>What CompressionSettings runtime format should imported floating point textures use</summary>
public enum ETextureImportFloatingPointFormat {
	HDR_F16=0,
	HDRCompressed_BC6=1,
	HDR_F32_or_F16=2,
	PreviousDefault=-1,
}
