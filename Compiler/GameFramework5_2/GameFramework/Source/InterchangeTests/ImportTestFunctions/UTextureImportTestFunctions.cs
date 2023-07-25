#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/TextureImportTestFunctions.h")]
public partial class UTextureImportTestFunctions : UImportTestFunctionsBase {
// TextureImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedTextureCount(TArray<UObject> Textures,int ExpectedNumberOfImportedTextures) { return default; }
	public FInterchangeTestFunctionResult CheckTextureFilter(UObject Texture,TextureFilter ExpectedTextureFilter) { return default; }
	public FInterchangeTestFunctionResult CheckTextureAddressX(UObject Texture,TextureAddress ExpectedTextureAddressX) { return default; }
	public FInterchangeTestFunctionResult CheckTextureAddressY(UObject Texture,TextureAddress ExpectedTextureAddressY) { return default; }
	public FInterchangeTestFunctionResult CheckTextureAddressZ(UObject Texture,TextureAddress ExpectedTextureAddressZ) { return default; }
}
