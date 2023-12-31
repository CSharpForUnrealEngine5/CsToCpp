namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureRenderTargetFactoryNew.h")]
public partial class UTextureRenderTargetFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the texture render target</summary>
	public int Width;
	///<summary>Height of the texture render target</summary>
	public int Height;
	///<summary>Pixel format of the texture render target</summary>
	public byte Format;
}
