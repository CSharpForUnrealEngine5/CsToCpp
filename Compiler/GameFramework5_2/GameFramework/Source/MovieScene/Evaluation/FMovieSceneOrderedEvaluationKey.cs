#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that stores the key for an evaluated entity, and the index at which it was (or is to be) evaluated</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneOrderedEvaluationKey {
	public FMovieSceneEvaluationKey Key;
	public ushort SetupIndex;
	public ushort TearDownIndex;
}
