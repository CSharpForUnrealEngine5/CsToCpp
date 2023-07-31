#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneTemplateGenerationLedger {
	public FMovieSceneTrackIdentifier LastTrackIdentifier;
	public TMap<FGuid,FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier;
	public TMap<FGuid,FMovieSceneFrameRange> SubSectionRanges;
}
