namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureRenderTargetVolume</summary>
[CppInclude("Engine/TextureRenderTargetVolume.h")]
public partial class UTextureRenderTargetVolume : UTextureRenderTarget {
	public static UClass StaticClass() {return default;}
	///<summary>The width of the texture.</summary>
	public int SizeX;
	///<summary>The height of the texture.</summary>
	public int SizeY;
	///<summary>The depth of the texture.</summary>
	public int SizeZ;
	///<summary>the color the texture is cleared to</summary>
	public FLinearColor ClearColor;
	///<summary>Normally the format is derived from bHDR, this allows code to set the format explicitly.</summary>
	public EPixelFormat OverrideFormat;
	///<summary>Whether to support storing HDR values, which requires more memory.</summary>
	public bool bHDR;
	///<summary>True to force linear gamma space for this render target</summary>
	public bool bForceLinearGamma;
}
