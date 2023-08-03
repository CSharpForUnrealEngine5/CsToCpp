#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture2DArray.h")]
public partial class UTexture2DArray : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>The addressing mode to use for the Z axis.</summary>
	public TextureAddress AddressZ;
	///<summary>Add Textures</summary>
	public TArray<UTexture2D> SourceTextures;
	///<summary>Is set to true if the source texture was generated from the SourceTextures array</summary>
	public bool bSourceGeneratedFromSourceTexturesArray;
}
