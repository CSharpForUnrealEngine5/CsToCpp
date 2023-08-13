namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
///<summary>What is the current overall state of the Pipeline? States are processed in order from first to</summary>
public enum EMovieRenderPipelineState {
	Uninitialized=0,
	ProducingFrames=1,
	Finalize=2,
	Export=3,
	Finished=4,
}
