namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that tracks warp counts in a way that works with the FMovieSceneTimeWarping struct.</summary>
[CppInclude("Evaluation/MovieSceneSequenceTransform.h")]
public partial struct FMovieSceneWarpCounter {
	public TArray<uint> WarpCounts;
}
