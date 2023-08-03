#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureRenderTarget2D</summary>
[CppInclude("Engine/TextureRenderTarget2D.h")]
public partial class UTextureRenderTarget2D : UTextureRenderTarget {
	public static UClass StaticClass() {return default;}
	///<summary>The width of the texture.</summary>
	public int SizeX;
	///<summary>The height of the texture.</summary>
	public int SizeY;
	///<summary>the color the texture is cleared to</summary>
	public FLinearColor ClearColor;
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>True to force linear gamma space for this render target</summary>
	public bool bForceLinearGamma;
	///<summary>Whether to support storing HDR values, which requires more memory.</summary>
	public bool bHDR_DEPRECATED;
	///<summary>Whether to support GPU sharing of the underlying native texture resource.</summary>
	public bool bGPUSharedFlag;
	///<summary>Format of the texture render target.</summary>
	public ETextureRenderTargetFormat RenderTargetFormat;
	///<summary>Whether to support Mip maps for this render target texture</summary>
	public bool bAutoGenerateMips;
	///<summary>Sampler filter type for AutoGenerateMips. Defaults to match texture filter.</summary>
	public TextureFilter MipsSamplerFilter;
	///<summary>AutoGenerateMips sampler address mode for U channel. Defaults to clamp.</summary>
	public TextureAddress MipsAddressU;
	///<summary>AutoGenerateMips sampler address mode for V channel. Defaults to clamp.</summary>
	public TextureAddress MipsAddressV;
	///<summary>Normally the format is derived from RenderTargetFormat, this allows code to set the format explicitly.</summary>
	public EPixelFormat OverrideFormat;
}
