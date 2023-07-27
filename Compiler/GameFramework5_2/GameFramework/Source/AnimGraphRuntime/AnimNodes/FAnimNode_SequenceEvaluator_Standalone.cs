#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_SequenceEvaluator.h")]
///<summary>Sequence evaluator node that can be used standalone (without constant folding)</summary>
public partial struct FAnimNode_SequenceEvaluator_Standalone {
// AnimNode_SequenceEvaluator_Standalone
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
