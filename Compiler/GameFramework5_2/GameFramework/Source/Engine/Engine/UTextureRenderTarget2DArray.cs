#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureRenderTarget2DArray</summary>
[CppInclude("Engine/TextureRenderTarget2DArray.h")]
public partial class UTextureRenderTarget2DArray : UTextureRenderTarget {
	public static UClass StaticClass() {return default;}
	///<summary>The width of the texture.</summary>
	public int SizeX;
	///<summary>The height of the texture.</summary>
	public int SizeY;
	///<summary>The slices of the texture.</summary>
	public int Slices;
	///<summary>the color the texture is cleared to</summary>
	public FLinearColor ClearColor;
	///<summary>Normally the format is derived from bHDR, this allows code to set the format explicitly.</summary>
	public EPixelFormat OverrideFormat;
	///<summary>Whether to support storing HDR values, which requires more memory.</summary>
	public bool bHDR;
	///<summary>True to force linear gamma space for this render target</summary>
	public bool bForceLinearGamma;
}
