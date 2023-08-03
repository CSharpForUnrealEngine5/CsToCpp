#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a texture asset for rendering video tracks from UBinkMediaPlayer assets.</summary>
[CppInclude("BinkMediaTexture.h")]
public partial class UBinkMediaTexture : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>Sets the media player asset to be used for this texture.</summary>
	public  void SetMediaPlayer(UBinkMediaPlayer InMediaPlayer) {}
	///<summary>Clears this texture to transparent-black.</summary>
	public  void Clear() {}
	///<summary>The MediaPlayer asset to stream video from.</summary>
	public UBinkMediaPlayer MediaPlayer;
	///<summary>The Pixel Format for the texture.</summary>
	public EPixelFormat PixelFormat;
	///<summary>Whether to enable tonemaping for the video.</summary>
	public bool Tonemap;
	///<summary>When tonemapping, set this for to desired output nits capability for the current display. Typically 80 for SDR, or 2000 for HDR.</summary>
	public float OutputNits;
	///<summary>alpha_value is just a constant blend value for entire video frame. 1 (default) opaque, 0 fully transparent.</summary>
	public float Alpha;
	///<summary>Enable decoding of sRGB to Linear inside Bink when drawing to this texture. You could use this when rendering to a texture format which doesn&#39;t support sRGB for example.</summary>
	public bool DecodeSRGB;
}
