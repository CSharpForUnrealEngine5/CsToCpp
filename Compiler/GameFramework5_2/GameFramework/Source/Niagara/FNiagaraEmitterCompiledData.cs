#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSystem.h")]
public partial struct FNiagaraEmitterCompiledData {
// NiagaraEmitterCompiledData
	public TArray<string> SpawnAttributes;
	public FNiagaraVariable EmitterSpawnIntervalVar;
	public FNiagaraVariable EmitterInterpSpawnStartDTVar;
	public FNiagaraVariable EmitterSpawnGroupVar;
	public FNiagaraVariable EmitterAgeVar;
	public FNiagaraVariable EmitterRandomSeedVar;
	public FNiagaraVariable EmitterInstanceSeedVar;
	public FNiagaraVariable EmitterTotalSpawnedParticlesVar;
	public FNiagaraDataSetCompiledData DataSetCompiledData;
	public FNiagaraDataSetCompiledData GPUCaptureDataSetCompiledData;
}
