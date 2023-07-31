#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data controlling the spawning of particles</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraSpawnInfo {
	public int Count;
	public float InterpStartDt;
	public float IntervalDt;
	public int SpawnGroup;
}
