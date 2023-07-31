#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scalability settings for Niagara Emitters on a particular platform set.</summary>
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraEmitterScalabilitySettings {
	public FNiagaraPlatformSet Platforms;
	public bool bScaleSpawnCount;
	public float SpawnCountScale;
}
