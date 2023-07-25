#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationKey.h")]
///<summary>Keyable struct that represents a particular entity within an evaluation template (either a section/template or a track)</summary>
public partial struct FMovieSceneEvaluationKey {
// MovieSceneEvaluationKey
	public FMovieSceneSequenceID SequenceID;
	public FMovieSceneTrackIdentifier TrackIdentifier;
	public uint SectionIndex;
}
