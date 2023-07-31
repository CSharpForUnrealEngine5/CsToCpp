#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheFrame {
	public FTransform LocalToWorld;
	public FVector3f LWCTile;
	public float SimulationAge;
	public int SimulationTickCount;
	public FNiagaraSimCacheSystemFrame SystemData;
	public TArray<FNiagaraSimCacheEmitterFrame> EmitterData;
}
