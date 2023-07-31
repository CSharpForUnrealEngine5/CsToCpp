#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene sequence transform class that transforms from one time-space to another.</summary>
[CppInclude("Evaluation/MovieSceneSequenceTransform.h")]
public partial struct FMovieSceneSequenceTransform {
	public FMovieSceneTimeTransform LinearTransform;
	public TArray<FMovieSceneNestedSequenceTransform> NestedTransforms;
}
