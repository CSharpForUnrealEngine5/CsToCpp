namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a texture asset for rendering video tracks from UMediaPlayer assets.</summary>
[CppInclude("MediaTexture.h")]
public partial class UMediaTexture : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
	///<summary>Whether to clear the texture when no media is being played (default = enabled).</summary>
	public bool AutoClear;
	///<summary>The color used to clear the texture if AutoClear is enabled (default = black).</summary>
	public FLinearColor ClearColor;
	///<summary>Basic enablement for mip generation (default = false).</summary>
	public bool EnableGenMips;
	///<summary>The number of mips to use (default = 1).</summary>
	public byte NumMips;
	///<summary>Enable new style output.</summary>
	public bool NewStyleOutput;
	///<summary>OutputFormat</summary>
	public MediaTextureOutputFormat OutputFormat;
	///<summary>Current aspect ratio</summary>
	public float CurrentAspectRatio;
	///<summary>Current media orientation</summary>
	public MediaTextureOrientation CurrentOrientation;
	///<summary>Gets the current aspect ratio of the texture.</summary>
	public float GetAspectRatio() { return default; }
	///<summary>Gets the current height of the texture.</summary>
	public int GetHeight() { return default; }
	///<summary>Gets the current width of the texture.</summary>
	public int GetWidth() { return default; }
	///<summary>Gets the current numbe of mips of the texture.</summary>
	public int GetTextureNumMips() { return default; }
	///<summary>Get the media player that provides the video samples.</summary>
	public UMediaPlayer GetMediaPlayer() { return default; }
	///<summary>Set the media player that provides the video samples.</summary>
	public void SetMediaPlayer(UMediaPlayer NewMediaPlayer) {}
	///<summary>Creates a new resource for the texture, and updates any cached references to the resource.</summary>
	public virtual void UpdateResource() {}
	///<summary>The media player asset associated with this texture.</summary>
	public UMediaPlayer MediaPlayer;
}
