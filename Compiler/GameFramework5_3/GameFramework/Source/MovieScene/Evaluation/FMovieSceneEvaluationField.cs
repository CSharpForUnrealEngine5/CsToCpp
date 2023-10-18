namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Memory layout optimized primarily for speed of searching the applicable ranges</summary>
[CppInclude("Evaluation/MovieSceneEvaluationField.h")]
public partial struct FMovieSceneEvaluationField {
	public FGuid Signature;
	public TArray<FMovieSceneFrameRange> Ranges;
	public TArray<FMovieSceneEvaluationGroup> Groups;
	public TArray<FMovieSceneEvaluationMetaData> MetaData;
}
