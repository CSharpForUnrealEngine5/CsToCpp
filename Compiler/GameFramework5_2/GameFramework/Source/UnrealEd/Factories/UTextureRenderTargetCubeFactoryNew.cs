namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureRenderTargetCubeFactoryNew.h")]
public partial class UTextureRenderTargetCubeFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the texture render target</summary>
	public int Width;
	///<summary>Pixel format of the texture render target</summary>
	public byte Format;
}
