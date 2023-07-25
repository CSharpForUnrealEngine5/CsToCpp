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
	public byte AddressX;
	public byte AddressY;
	public bool bForceLinearGamma;
	public bool bHDR_DEPRECATED;
	public bool bGPUSharedFlag;
	public byte RenderTargetFormat;
	public bool bAutoGenerateMips;
	public byte MipsSamplerFilter;
	public byte MipsAddressU;
	public byte MipsAddressV;
	public byte OverrideFormat;
}
