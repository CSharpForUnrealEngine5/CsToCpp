namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container struct for an array of emitter scalability overrides. Enables details customization and data validation.</summary>
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraEmitterScalabilityOverrides {
	public TArray<FNiagaraEmitterScalabilityOverride> Overrides;
}
