#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonVideoPlayer.h")]
public partial class UCommonVideoPlayer : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Video</summary>
	public UMediaSource Video;
	///<summary>MediaPlayer</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>MediaTexture</summary>
	public UMediaTexture MediaTexture;
	///<summary>VideoMaterial</summary>
	public UMaterial VideoMaterial;
	///<summary>SoundComponent</summary>
	public UMediaSoundComponent SoundComponent;
	///<summary>VideoBrush</summary>
	public FSlateBrush VideoBrush;
}
