#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Determinism data that is generated on compile of a UMovieSceneSequence</summary>
[CppInclude("Compilation/IMovieSceneDeterminismSource.h")]
public partial struct FMovieSceneDeterminismData {
	public TArray<FFrameTime> Fences;
	public bool bParentSequenceRequiresLowerFence;
	public bool bParentSequenceRequiresUpperFence;
}
