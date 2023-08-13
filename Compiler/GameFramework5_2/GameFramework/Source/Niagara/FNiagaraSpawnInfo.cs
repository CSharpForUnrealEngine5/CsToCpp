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
