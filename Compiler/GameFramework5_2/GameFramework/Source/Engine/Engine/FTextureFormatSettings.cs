#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture.h")]
///<summary>Collection of values that contribute to pixel format chosen for texture</summary>
public partial struct FTextureFormatSettings {
// TextureFormatSettings
	public TextureCompressionSettings CompressionSettings;
	public bool CompressionNoAlpha;
	public bool CompressionForceAlpha;
	public bool CompressionNone;
	public bool CompressionYCoCg;
	public bool SRGB;
}
