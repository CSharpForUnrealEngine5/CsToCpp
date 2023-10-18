namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene section for media playback.</summary>
[CppInclude("MovieSceneMediaSection.h")]
public partial class UMovieSceneMediaSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>The source to play with this video track if MediaSourceProxy is not available.</summary>
	public UMediaSource MediaSource;
	///<summary>The index to pass to MediaSourceProxy to get the media source.</summary>
	public int MediaSourceProxyIndex;
	///<summary>Should the media player be set to loop? This can be helpful for media formats that can use this information (such as exr sequences) to pre-cache the starting data when nearing the end of playback. Does not cause the media to continue playing after the end of the section is reached.</summary>
	public bool bLooping;
	///<summary>Offset into the source media.</summary>
	public FFrameNumber StartFrameOffset;
	///<summary>The media texture that receives the track&#39;s video output.</summary>
	public UMediaTexture MediaTexture;
	///<summary>The media sound component that receives the track&#39;s audio output.</summary>
	public UMediaSoundComponent MediaSoundComponent;
	///<summary>If true, this track will control a previously created media player instead of automatically creating one.</summary>
	public bool bUseExternalMediaPlayer;
	///<summary>The external media player this track should control.</summary>
	public UMediaPlayer ExternalMediaPlayer;
	///<summary>Override the default cache settings. Not used if we have a player proxy as the settings come from the proxy instead.</summary>
	public FMediaSourceCacheSettings CacheSettings;
	///<summary>If using an object like a MediaPlate, then this determines which texture to use for crossfading purposes.</summary>
	public int TextureIndex;
	///<summary>True if the object bound to this track has a media player proxy.</summary>
	public bool bHasMediaPlayerProxy;
	///<summary>If true then the media player can be open.</summary>
	public FMovieSceneBoolChannel ChannelCanPlayerBeOpen;
	///<summary>The reference frame offset for single thumbnail rendering</summary>
	public float ThumbnailReferenceOffset;
	///<summary>The object to get the source to play from if you don&#39;t want to directly specify a media source.</summary>
	public FMovieSceneObjectBindingID MediaSourceProxyBindingID;
}
