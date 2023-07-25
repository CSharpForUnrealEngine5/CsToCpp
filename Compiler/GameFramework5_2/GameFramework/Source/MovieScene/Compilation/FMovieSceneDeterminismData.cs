#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Compilation/IMovieSceneDeterminismSource.h")]
///<summary>Determinism data that is generated on compile of a UMovieSceneSequence</summary>
public partial struct FMovieSceneDeterminismData {
// MovieSceneDeterminismData
	public TArray<FFrameTime> Fences;
	public bool bParentSequenceRequiresLowerFence;
	public bool bParentSequenceRequiresUpperFence;
}
