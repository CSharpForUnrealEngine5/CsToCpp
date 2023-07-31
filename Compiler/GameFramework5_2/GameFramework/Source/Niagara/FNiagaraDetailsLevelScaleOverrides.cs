#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Legacy struct for spawn count scale overrides. This is now done in FNiagaraEmitterScalabilityOverrides</summary>
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraDetailsLevelScaleOverrides {
	public float Low;
	public float Medium;
	public float High;
	public float Epic;
	public float Cine;
}
