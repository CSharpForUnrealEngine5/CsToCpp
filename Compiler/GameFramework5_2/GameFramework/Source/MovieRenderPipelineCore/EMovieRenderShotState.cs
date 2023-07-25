#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
///<summary>What is the current state of a shot? States are processed in order from first to last but not</summary>
public enum EMovieRenderShotState {
	Uninitialized=0,
	WarmingUp=1,
	MotionBlur=2,
	Rendering=3,
	Finished=4,
}
