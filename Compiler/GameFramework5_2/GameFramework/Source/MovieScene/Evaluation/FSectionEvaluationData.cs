#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSegment.h")]
///<summary>Evaluation data that specifies information about what to evaluate for a given template</summary>
public partial struct FSectionEvaluationData {
// SectionEvaluationData
	public int ImplIndex;
	public FFrameNumber ForcedTime;
	public ESectionEvaluationFlags Flags;
}
