#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps assets alive during level loading so they don&#39;t get garbage collected while we are using them.</summary>
[CppInclude("MediaMovieAssets.h")]
public partial class UMediaMovieAssets : UObject {
	///<summary>Called by the media player when the video ends.</summary>
	public  void OnMediaEnd() {}
	///<summary>Holds the player we are using.</summary>
	public UMediaPlayer MediaPlayer;
	///<summary>Holds the media sound component we are using.</summary>
	public UMediaSoundComponent MediaSoundComponent;
	///<summary>Holds the media source we are using.</summary>
	public UMediaSource MediaSource;
	///<summary>Holds the media texture we are using.</summary>
	public UMediaTexture MediaTexture;
}
