namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSystem.h")]
public partial struct FNiagaraEmitterCompiledData {
	public TArray<FName> SpawnAttributes;
	public FNiagaraVariable EmitterSpawnIntervalVar;
	public FNiagaraVariable EmitterInterpSpawnStartDTVar;
	public FNiagaraVariable EmitterSpawnGroupVar;
	public FNiagaraVariable EmitterAgeVar;
	public FNiagaraVariable EmitterRandomSeedVar;
	public FNiagaraVariable EmitterInstanceSeedVar;
	public FNiagaraVariable EmitterTotalSpawnedParticlesVar;
	public FNiagaraDataSetCompiledData DataSetCompiledData;
}
