#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/TextureImportTestFunctions.h")]
public partial class UTextureImportTestFunctions : UImportTestFunctionsBase {
// TextureImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedTextureCount(TArray<UTexture> Textures,int ExpectedNumberOfImportedTextures) { return default; }
	public static FInterchangeTestFunctionResult CheckTextureFilter(UTexture Texture,TextureFilter ExpectedTextureFilter) { return default; }
	public static FInterchangeTestFunctionResult CheckTextureAddressX(UTexture Texture,TextureAddress ExpectedTextureAddressX) { return default; }
	public static FInterchangeTestFunctionResult CheckTextureAddressY(UTexture Texture,TextureAddress ExpectedTextureAddressY) { return default; }
	public static FInterchangeTestFunctionResult CheckTextureAddressZ(UTexture Texture,TextureAddress ExpectedTextureAddressZ) { return default; }
}
