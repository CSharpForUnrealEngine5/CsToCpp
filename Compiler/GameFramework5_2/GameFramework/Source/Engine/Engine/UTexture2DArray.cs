#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture2DArray.h")]
public partial class UTexture2DArray : UTexture {
// Texture2DArray
	public TextureAddress AddressX;
	public TextureAddress AddressY;
	public TextureAddress AddressZ;
	public TArray<UTexture2D> SourceTextures;
	public bool bSourceGeneratedFromSourceTexturesArray;
}
