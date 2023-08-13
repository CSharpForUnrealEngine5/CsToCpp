namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sequence evaluator node that can be used with constant folding</summary>
[CppInclude("AnimNodes/AnimNode_SequenceEvaluator.h")]
public partial struct FAnimNode_SequenceEvaluator {
	public string GroupName;
	public EAnimGroupRole GroupRole;
	public EAnimSyncMethod Method;
	public bool bIgnoreForRelevancyTest;
	public UAnimSequenceBase Sequence;
	public float ExplicitTime;
	public bool bShouldLoop;
	public bool bTeleportToExplicitTime;
	public ESequenceEvalReinit ReinitializationBehavior;
	public float StartPosition;
}
