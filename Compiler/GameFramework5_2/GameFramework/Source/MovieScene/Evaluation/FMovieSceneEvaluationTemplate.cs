#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
///<summary>Template that is used for efficient runtime evaluation of a movie scene sequence. Potentially serialized into the asset.</summary>
public partial struct FMovieSceneEvaluationTemplate {
// MovieSceneEvaluationTemplate
	public TMap<FMovieSceneTrackIdentifier,FMovieSceneEvaluationTrack> Tracks;
	public FGuid SequenceSignature;
	public FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber;
	public FMovieSceneTemplateGenerationLedger TemplateLedger;
}
