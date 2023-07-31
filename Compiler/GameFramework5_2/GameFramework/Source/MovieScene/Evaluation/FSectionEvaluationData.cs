#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluation data that specifies information about what to evaluate for a given template</summary>
[CppInclude("Evaluation/MovieSceneSegment.h")]
public partial struct FSectionEvaluationData {
	public int ImplIndex;
	public FFrameNumber ForcedTime;
	public ESectionEvaluationFlags Flags;
}
