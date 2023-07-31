#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/TextureImportTestFunctions.h")]
public partial class UTextureImportTestFunctions : UImportTestFunctionsBase {
	///<summary>Check whether the expected number of textures are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedTextureCount(TArray<UTexture> Textures,int ExpectedNumberOfImportedTextures) { return default; }
	///<summary>Check whether the imported texture has the expected filtering mode</summary>
	public static FInterchangeTestFunctionResult CheckTextureFilter(UTexture Texture,TextureFilter ExpectedTextureFilter) { return default; }
	///<summary>Check whether the imported texture has the expected addressing mode for X-axis</summary>
	public static FInterchangeTestFunctionResult CheckTextureAddressX(UTexture Texture,TextureAddress ExpectedTextureAddressX) { return default; }
	///<summary>Check whether the imported texture has the expected addressing mode for Y-axis</summary>
	public static FInterchangeTestFunctionResult CheckTextureAddressY(UTexture Texture,TextureAddress ExpectedTextureAddressY) { return default; }
	///<summary>Check whether the imported texture has the expected addressing mode for Z-axis</summary>
	public static FInterchangeTestFunctionResult CheckTextureAddressZ(UTexture Texture,TextureAddress ExpectedTextureAddressZ) { return default; }
}
