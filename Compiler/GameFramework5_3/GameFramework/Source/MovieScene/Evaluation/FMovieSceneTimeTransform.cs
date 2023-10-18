namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene sequence transform class that transforms from one time-space to another.</summary>
[CppInclude("Evaluation/MovieSceneTimeTransform.h")]
public partial struct FMovieSceneTimeTransform {
	public float TimeScale;
	public FFrameTime Offset;
}
