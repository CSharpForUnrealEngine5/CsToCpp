#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture2D.h")]
public partial class UTexture2D : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>keep track of first mip level used for ResourceMem creation</summary>
	public int FirstResourceMemMip;
	///<summary>True if streaming is temporarily disabled so we can update subregions of this texture&#39;s resource</summary>
	public bool bTemporarilyDisableStreaming;
	///<summary>Whether the texture has been painted in the editor.</summary>
	public bool bHasBeenPaintedInEditor;
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>The imported size of the texture. Only valid on cooked builds when texture source is not</summary>
	public FIntPoint ImportedSize;
	///<summary>Gets the X size of the texture, in pixels</summary>
	public  int Blueprint_GetSizeX() { return default; }
	///<summary>Gets the Y size of the texture, in pixels</summary>
	public  int Blueprint_GetSizeY() { return default; }
}
