#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneTemplateGenerationLedger {
// MovieSceneTemplateGenerationLedger
	public FMovieSceneTrackIdentifier LastTrackIdentifier;
	public TMap<FGuid,FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier;
	public TMap<FGuid,FMovieSceneFrameRange> SubSectionRanges;
}
