#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaMovieAssets.h")]
///<summary>Keeps assets alive during level loading so they don't get garbage collected while we are using them.</summary>
public partial class UMediaMovieAssets : UObject {
// MediaMovieAssets
	public void OnMediaEnd() {}
	public UMediaPlayer MediaPlayer;
	public UMediaSoundComponent MediaSoundComponent;
	public UMediaSource MediaSource;
	public UMediaTexture MediaTexture;
}
