#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles manipulation of audio.</summary>
[CppInclude("Tracks/MovieSceneAudioTrack.h")]
public partial class UMovieSceneAudioTrack : UMovieSceneNameableTrack {
	///<summary>List of all root audio sections</summary>
	public TArray<UMovieSceneSection> AudioSections;
	///<summary>The height for each row of this track</summary>
	public int RowHeight;
}
