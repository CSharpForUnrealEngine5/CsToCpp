#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureRenderTarget2D.h")]
///<summary>TextureRenderTarget2D</summary>
public partial class UTextureRenderTarget2D : UTextureRenderTarget {
// TextureRenderTarget2D
	public int SizeX;
	public int SizeY;
	public FLinearColor ClearColor;
	public TextureAddress AddressX;
	public TextureAddress AddressY;
	public bool bForceLinearGamma;
	public bool bHDR_DEPRECATED;
	public bool bGPUSharedFlag;
	public ETextureRenderTargetFormat RenderTargetFormat;
	public bool bAutoGenerateMips;
	public TextureFilter MipsSamplerFilter;
	public TextureAddress MipsAddressU;
	public TextureAddress MipsAddressV;
	public EPixelFormat OverrideFormat;
}
