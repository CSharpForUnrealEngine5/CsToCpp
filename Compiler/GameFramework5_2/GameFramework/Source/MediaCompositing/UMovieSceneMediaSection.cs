#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneMediaSection.h")]
///<summary>Implements a movie scene section for media playback.</summary>
public partial class UMovieSceneMediaSection : UMovieSceneSection {
// MovieSceneMediaSection
	public UMediaSource MediaSource;
	public int MediaSourceProxyIndex;
	public bool bLooping;
	public FFrameNumber StartFrameOffset;
	public UMediaTexture MediaTexture;
	public UMediaSoundComponent MediaSoundComponent;
	public bool bUseExternalMediaPlayer;
	public UMediaPlayer ExternalMediaPlayer;
	public FMediaSourceCacheSettings CacheSettings;
	public int TextureIndex;
	public bool bHasMediaPlayerProxy;
	public float ThumbnailReferenceOffset;
	public FMovieSceneObjectBindingID MediaSourceProxyBindingID;
}
