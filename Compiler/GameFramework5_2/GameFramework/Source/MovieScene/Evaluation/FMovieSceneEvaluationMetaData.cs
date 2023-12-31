namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Informational meta-data that applies to a given time range</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneEvaluationMetaData {
	public TArray<FMovieSceneSequenceID> ActiveSequences;
	public TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities;
}
