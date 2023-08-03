#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/CanvasRenderTarget2DFactoryNew.h")]
public partial class UCanvasRenderTarget2DFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Width of the texture render target</summary>
	public int Width;
	///<summary>Height of the texture render target</summary>
	public int Height;
	///<summary>Pixel format of the texture render target</summary>
	public byte Format;
}
