namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/TextureRenderTargetVolumeFactoryNew.h")]
public partial class UTextureRenderTargetVolumeFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the texture render target</summary>
	public int Width;
	///<summary>Height of the texture render target</summary>
	public int Height;
	///<summary>Depth of the texture render target</summary>
	public int Depth;
	///<summary>Pixel format of the texture render target</summary>
	public byte Format;
}
