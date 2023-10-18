namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container struct for an array of system scalability overrides. Enables details customization and data validation.</summary>
[CppInclude("NiagaraSystem.h")]
public partial struct FNiagaraSystemScalabilityOverrides {
	public TArray<FNiagaraSystemScalabilityOverride> Overrides;
}
