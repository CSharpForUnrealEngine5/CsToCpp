#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a movie scene section for media playback on a UMediaPlayer.</summary>
[CppInclude("MovieSceneMediaPlayerPropertySection.h")]
public partial class UMovieSceneMediaPlayerPropertySection : UMovieSceneSection {
	///<summary>The source to play with this video track.</summary>
	public UMediaSource MediaSource;
	///<summary>Whether to loop this video.</summary>
	public bool bLoop;
}
