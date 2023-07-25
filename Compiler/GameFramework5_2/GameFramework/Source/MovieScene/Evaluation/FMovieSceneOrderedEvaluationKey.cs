#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>Struct that stores the key for an evaluated entity, and the index at which it was (or is to be) evaluated</summary>
public partial struct FMovieSceneOrderedEvaluationKey {
// MovieSceneOrderedEvaluationKey
	public FMovieSceneEvaluationKey Key;
	public ushort SetupIndex;
	public ushort TearDownIndex;
}
