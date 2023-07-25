#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
///<summary>Memory layout optimized primarily for speed of searching the applicable ranges</summary>
public partial struct FMovieSceneEvaluationField {
// MovieSceneEvaluationField
	public FGuid Signature;
	public TArray<FMovieSceneFrameRange> Ranges;
	public TArray<FMovieSceneEvaluationGroup> Groups;
	public TArray<FMovieSceneEvaluationMetaData> MetaData;
}
