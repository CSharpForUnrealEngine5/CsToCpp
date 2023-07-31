#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collection of values that contribute to pixel format chosen for texture</summary>
[CppInclude("Engine/Texture.h")]
public partial struct FTextureFormatSettings {
	public TextureCompressionSettings CompressionSettings;
	public bool CompressionNoAlpha;
	public bool CompressionForceAlpha;
	public bool CompressionNone;
	public bool CompressionYCoCg;
	public bool SRGB;
}
