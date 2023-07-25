#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureRenderTarget2DArray.h")]
///<summary>TextureRenderTarget2DArray</summary>
public partial class UTextureRenderTarget2DArray : UTextureRenderTarget {
// TextureRenderTarget2DArray
	public int SizeX;
	public int SizeY;
	public int Slices;
	public FLinearColor ClearColor;
	public byte OverrideFormat;
	public bool bHDR;
	public bool bForceLinearGamma;
}
