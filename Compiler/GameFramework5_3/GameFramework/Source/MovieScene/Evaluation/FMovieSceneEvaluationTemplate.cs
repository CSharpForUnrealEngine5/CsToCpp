namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Template that is used for efficient runtime evaluation of a movie scene sequence. Potentially serialized into the asset.</summary>
[CppInclude("Evaluation/MovieSceneEvaluationTemplate.h")]
public partial struct FMovieSceneEvaluationTemplate {
	public TMap<FMovieSceneTrackIdentifier,FMovieSceneEvaluationTrack> Tracks;
	public FGuid SequenceSignature;
	public FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber;
	public FMovieSceneTemplateGenerationLedger TemplateLedger;
}
