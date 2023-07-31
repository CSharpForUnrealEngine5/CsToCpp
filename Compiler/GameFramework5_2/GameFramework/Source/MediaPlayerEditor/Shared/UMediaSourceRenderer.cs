#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Renders a media source to a texture in editor builds.</summary>
[CppInclude("Shared/MediaSourceRenderer.h")]
public partial class UMediaSourceRenderer : UObject {
	///<summary>Callback when the media player is done seeking.</summary>
	public  void OnSeekCompleted() {}
	///<summary>Holds the player we are using.</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>Holds the media source we are using.</summary>
	public UMediaSource MediaSource;
	///<summary>Holds the media texture we are using.</summary>
	public UMediaTexture MediaTexture;
}
