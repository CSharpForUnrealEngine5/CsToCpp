#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>High-level container which acts as a look-up-table for IMovieSceneEntityProviders and their entities and meta-data in a sequence</summary>
public partial struct FMovieSceneEntityComponentField {
// MovieSceneEntityComponentField
	public FMovieSceneEvaluationFieldEntityTree PersistentEntityTree;
	public FMovieSceneEvaluationFieldEntityTree OneShotEntityTree;
	public TArray<FMovieSceneEvaluationFieldEntity> Entities;
	public TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData;
	public TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData;
}
