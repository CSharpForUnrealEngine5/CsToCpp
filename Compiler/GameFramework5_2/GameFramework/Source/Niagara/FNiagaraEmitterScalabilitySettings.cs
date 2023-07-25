#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
///<summary>Scalability settings for Niagara Emitters on a particular platform set.</summary>
public partial struct FNiagaraEmitterScalabilitySettings {
// NiagaraEmitterScalabilitySettings
	public FNiagaraPlatformSet Platforms;
	public bool bScaleSpawnCount;
	public float SpawnCountScale;
}
