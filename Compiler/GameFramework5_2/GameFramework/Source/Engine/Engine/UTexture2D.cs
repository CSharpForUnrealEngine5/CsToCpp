#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Texture2D.h")]
public partial class UTexture2D : UTexture {
// Texture2D
	public int FirstResourceMemMip;
	public bool bTemporarilyDisableStreaming;
	public bool bHasBeenPaintedInEditor;
	public TextureAddress AddressX;
	public TextureAddress AddressY;
	public FIntPoint ImportedSize;
	public  int Blueprint_GetSizeX() { return default; }
	public  int Blueprint_GetSizeY() { return default; }
}
