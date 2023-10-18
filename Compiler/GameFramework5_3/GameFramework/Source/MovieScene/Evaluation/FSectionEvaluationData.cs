namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluation data that specifies information about what to evaluate for a given template</summary>
[CppInclude("Evaluation/MovieSceneSegment.h")]
public partial struct FSectionEvaluationData {
	public int ImplIndex;
	public FFrameNumber ForcedTime;
	public ESectionEvaluationFlags Flags;
}
