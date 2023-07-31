#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public enum ENiagaraSystemInstanceState {
	None=0,
	PendingSpawn=1,
	PendingSpawnPaused=2,
	Spawning=3,
	Running=4,
	Paused=5,
	Num=6,
}
