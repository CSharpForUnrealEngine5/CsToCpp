namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule can be used to enforce a budget on the number of simulation stages and the iterations that may execute.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_SimulationStageBudget : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
	///<summary>bMaxSimulationStagesEnabled</summary>
	public bool bMaxSimulationStagesEnabled;
	///<summary>bMaxIterationsPerStageEnabled</summary>
	public bool bMaxIterationsPerStageEnabled;
	///<summary>bMaxTotalIterationsEnabled</summary>
	public bool bMaxTotalIterationsEnabled;
	///<summary>How do we want to repro the error in the stack</summary>
	public ENiagaraValidationSeverity Severity;
	///<summary>Maximum number of simulation stages allowed, where 0 means no simulation stages.</summary>
	public int MaxSimulationStages;
	///<summary>Maximum number of iterations a single stage is allowed to execute.</summary>
	public int MaxIterationsPerStage;
	///<summary>Maximum total iterations across all the enabled simulation stages.</summary>
	public int MaxTotalIterations;
}
