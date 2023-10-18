namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>High-level container which acts as a look-up-table for IMovieSceneEntityProviders and their entities and meta-data in a sequence</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneEntityComponentField {
	public FMovieSceneEvaluationFieldEntityTree PersistentEntityTree;
	public FMovieSceneEvaluationFieldEntityTree OneShotEntityTree;
	public TArray<FMovieSceneEvaluationFieldEntity> Entities;
	public TArray<FMovieSceneEvaluationFieldEntityMetaData> EntityMetaData;
	public TArray<FMovieSceneEvaluationFieldSharedEntityMetaData> SharedMetaData;
}
