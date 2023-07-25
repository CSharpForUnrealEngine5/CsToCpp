#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraValidationRules.h")]
///<summary>This validation rule can be used to enforce a budget on the number of simulation stages and the iterations that may execute.</summary>
public partial class UNiagaraValidationRule_SimulationStageBudget : UNiagaraValidationRule {
// NiagaraValidationRule_SimulationStageBudget
	public bool bMaxSimulationStagesEnabled;
	public bool bMaxIterationsPerStageEnabled;
	public bool bMaxTotalIterationsEnabled;
	public ENiagaraValidationSeverity Severity;
	public int MaxSimulationStages;
	public int MaxIterationsPerStage;
	public int MaxTotalIterations;
}
