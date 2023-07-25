#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>Informational meta-data that applies to a given time range</summary>
public partial struct FMovieSceneEvaluationMetaData {
// MovieSceneEvaluationMetaData
	public TArray<FMovieSceneSequenceID> ActiveSequences;
	public TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities;
}
