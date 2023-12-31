namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Renders a media source to a texture in editor builds.</summary>
[CppInclude("Shared/MediaSourceRenderer.h")]
public partial class UMediaSourceRenderer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Callback when the media player is done seeking.</summary>
	public void OnSeekCompleted() {}
	///<summary>Holds the player we are using.</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>Holds the media source we are using.</summary>
	public UMediaSource MediaSource;
	///<summary>Holds the media texture we are using.</summary>
	public UMediaTexture MediaTexture;
}
