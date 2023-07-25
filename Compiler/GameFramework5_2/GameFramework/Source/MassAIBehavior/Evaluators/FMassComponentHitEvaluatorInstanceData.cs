#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluators/MassComponentHitEvaluator.h")]
///<summary>Evaluator to extract last hit from the MassComponentHitSubsystem and expose it for tasks and transitions</summary>
public partial struct FMassComponentHitEvaluatorInstanceData {
// MassComponentHitEvaluatorInstanceData
	public bool bGotHit;
	public FMassEntityHandle LastHitEntity;
}
