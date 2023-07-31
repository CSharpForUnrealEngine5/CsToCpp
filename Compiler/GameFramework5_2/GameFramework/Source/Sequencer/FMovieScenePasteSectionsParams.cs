#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Paste sections params</summary>
[CppInclude("SequencerUtilities.h")]
public partial struct FMovieScenePasteSectionsParams {
	public TArray<UMovieSceneTrack> Tracks;
	public TArray<int> TrackRowIndices;
	public FFrameTime Time;
}
