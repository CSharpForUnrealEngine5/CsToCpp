namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluator to extract last hit from the MassComponentHitSubsystem and expose it for tasks and transitions</summary>
[CppInclude("Evaluators/MassComponentHitEvaluator.h")]
public partial struct FMassComponentHitEvaluatorInstanceData {
	public bool bGotHit;
	public FMassEntityHandle LastHitEntity;
}
