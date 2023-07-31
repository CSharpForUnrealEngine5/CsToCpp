#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sequence evaluator node that can be used standalone (without constant folding)</summary>
[CppInclude("AnimNodes/AnimNode_SequenceEvaluator.h")]
public partial struct FAnimNode_SequenceEvaluator_Standalone {
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
