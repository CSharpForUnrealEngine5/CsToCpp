namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneTemplateGenerationLedger {
	public FMovieSceneTrackIdentifier LastTrackIdentifier;
	public TMap<FGuid,FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier;
	public TMap<FGuid,FMovieSceneFrameRange> SubSectionRanges;
}
