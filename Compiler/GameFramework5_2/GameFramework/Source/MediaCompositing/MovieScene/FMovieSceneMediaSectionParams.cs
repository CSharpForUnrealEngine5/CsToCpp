namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneMediaTemplate.h")]
public partial struct FMovieSceneMediaSectionParams {
	public UMediaSoundComponent MediaSoundComponent;
	public UMediaSource MediaSource;
	public FMovieSceneObjectBindingID MediaSourceProxy;
	public int MediaSourceProxyIndex;
	public UMediaTexture MediaTexture;
	public UMediaPlayer MediaPlayer;
	public FFrameNumber SectionStartFrame;
	public FFrameNumber SectionEndFrame;
	public bool bLooping;
	public FFrameNumber StartFrameOffset;
	public FMovieSceneFloatChannel ProxyTextureBlend;
}
