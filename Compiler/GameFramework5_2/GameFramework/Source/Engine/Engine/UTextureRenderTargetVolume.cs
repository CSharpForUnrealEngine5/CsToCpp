#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureRenderTargetVolume.h")]
///<summary>TextureRenderTargetVolume</summary>
public partial class UTextureRenderTargetVolume : UTextureRenderTarget {
// TextureRenderTargetVolume
	public int SizeX;
	public int SizeY;
	public int SizeZ;
	public FLinearColor ClearColor;
	public byte OverrideFormat;
	public bool bHDR;
	public bool bForceLinearGamma;
}
