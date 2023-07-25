#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraGlobalBudgetScaling {
// NiagaraGlobalBudgetScaling
	public bool bCullByGlobalBudget;
	public bool bScaleMaxDistanceByGlobalBudgetUse;
	public bool bScaleMaxInstanceCountByGlobalBudgetUse;
	public bool bScaleSystemInstanceCountByGlobalBudgetUse;
	public float MaxGlobalBudgetUsage;
	public FNiagaraLinearRamp MaxDistanceScaleByGlobalBudgetUse;
	public FNiagaraLinearRamp MaxInstanceCountScaleByGlobalBudgetUse;
	public FNiagaraLinearRamp MaxSystemInstanceCountScaleByGlobalBudgetUse;
}
