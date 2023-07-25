#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/SNiagaraDebuggerSpawn.h")]
public partial struct FNiagaraDebuggerSpawnData {
// NiagaraDebuggerSpawnData
	public TArray<TSoftObjectPtr<UNiagaraSystem>> SystemsToSpawn;
	public bool bSpawnAllAtOnce;
	public float TimeBetweenSpawns;
	public bool bKillBeforeSpawn;
	public bool bWorldLocation;
	public FVector Location;
	public bool bAttachToPlayer;
	public bool bAutoActivate;
	public bool bAutoDestroy;
	public bool bDoPreCullCheck;
}
