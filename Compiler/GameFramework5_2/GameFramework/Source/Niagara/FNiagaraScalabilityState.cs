namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScalabilityState.h")]
public partial struct FNiagaraScalabilityState {
	public float Significance;
	public float LastVisibleTime;
	public bool bCulled;
	public bool bPreviousCulled;
	public bool bCulledByDistance;
	public bool bCulledByInstanceCount;
	public bool bCulledByVisibility;
	public bool bCulledByGlobalBudget;
}
