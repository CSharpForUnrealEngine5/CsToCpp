namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureRenderTarget2DArrayFactoryNew.h")]
public partial class UTextureRenderTarget2DArrayFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the texture render target</summary>
	public int Width;
	///<summary>Height of the texture render target</summary>
	public int Height;
	///<summary>Slices of the texture render target</summary>
	public int Slices;
	///<summary>Pixel format of the texture render target</summary>
	public byte Format;
}
