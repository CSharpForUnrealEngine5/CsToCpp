namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation data node for state machine transitions.</summary>
[CppInclude("Animation/AnimNode_TransitionPoseEvaluator.h")]
public partial struct FAnimNode_TransitionPoseEvaluator {
	public int FramesToCachePose;
	public EEvaluatorDataSource DataSource;
	public EEvaluatorMode EvaluatorMode;
}
