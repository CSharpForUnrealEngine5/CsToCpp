#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BinkMediaTexture.h")]
///<summary>Implements a texture asset for rendering video tracks from UBinkMediaPlayer assets.</summary>
public partial class UBinkMediaTexture : UTexture {
// BinkMediaTexture
	public byte AddressX;
	public byte AddressY;
	public void SetMediaPlayer(UObject InMediaPlayer) {}
	public void Clear() {}
	public UBinkMediaPlayer MediaPlayer;
	public byte PixelFormat;
	public bool Tonemap;
	public float OutputNits;
	public float Alpha;
	public bool DecodeSRGB;
}
