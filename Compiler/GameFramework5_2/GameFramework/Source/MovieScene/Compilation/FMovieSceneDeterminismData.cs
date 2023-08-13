namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Determinism data that is generated on compile of a UMovieSceneSequence</summary>
[CppInclude("Compilation/IMovieSceneDeterminismSource.h")]
public partial struct FMovieSceneDeterminismData {
	public TArray<FFrameTime> Fences;
	public bool bParentSequenceRequiresLowerFence;
	public bool bParentSequenceRequiresUpperFence;
}
