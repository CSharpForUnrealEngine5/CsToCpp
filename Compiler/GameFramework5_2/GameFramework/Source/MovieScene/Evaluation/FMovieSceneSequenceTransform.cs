#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSequenceTransform.h")]
///<summary>Movie scene sequence transform class that transforms from one time-space to another.</summary>
public partial struct FMovieSceneSequenceTransform {
// MovieSceneSequenceTransform
	public FMovieSceneTimeTransform LinearTransform;
	public TArray<FMovieSceneNestedSequenceTransform> NestedTransforms;
}
