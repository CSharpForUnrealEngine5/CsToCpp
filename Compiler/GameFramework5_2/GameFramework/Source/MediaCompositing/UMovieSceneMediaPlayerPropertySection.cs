namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene section for media playback on a UMediaPlayer.</summary>
[CppInclude("MovieSceneMediaPlayerPropertySection.h")]
public partial class UMovieSceneMediaPlayerPropertySection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>The source to play with this video track.</summary>
	public UMediaSource MediaSource;
	///<summary>Whether to loop this video.</summary>
	public bool bLoop;
}
