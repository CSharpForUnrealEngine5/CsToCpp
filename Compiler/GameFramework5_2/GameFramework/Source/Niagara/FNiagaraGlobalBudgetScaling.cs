#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraGlobalBudgetScaling {
	public bool bCullByGlobalBudget;
	public bool bScaleMaxDistanceByGlobalBudgetUse;
	public bool bScaleMaxInstanceCountByGlobalBudgetUse;
	public bool bScaleSystemInstanceCountByGlobalBudgetUse;
	public float MaxGlobalBudgetUsage;
	public FNiagaraLinearRamp MaxDistanceScaleByGlobalBudgetUse;
	public FNiagaraLinearRamp MaxInstanceCountScaleByGlobalBudgetUse;
	public FNiagaraLinearRamp MaxSystemInstanceCountScaleByGlobalBudgetUse;
}
