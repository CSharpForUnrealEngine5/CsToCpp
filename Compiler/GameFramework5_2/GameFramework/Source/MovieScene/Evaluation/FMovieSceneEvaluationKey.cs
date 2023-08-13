namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyable struct that represents a particular entity within an evaluation template (either a section/template or a track)</summary>
[CppInclude("Evaluation/MovieSceneEvaluationKey.h")]
public partial struct FMovieSceneEvaluationKey {
	public FMovieSceneSequenceID SequenceID;
	public FMovieSceneTrackIdentifier TrackIdentifier;
	public uint SectionIndex;
}
