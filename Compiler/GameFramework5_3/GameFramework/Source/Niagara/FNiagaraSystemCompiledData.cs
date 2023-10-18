namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSystem.h")]
public partial struct FNiagaraSystemCompiledData {
	public FNiagaraParameterStore InstanceParamStore;
	public FNiagaraDataSetCompiledData DataSetCompiledData;
	public FNiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData;
	public FNiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData;
	public FNiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding;
	public FNiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding;
	public FNiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding;
	public TArray<FNiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings;
	public FNiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding;
	public FNiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding;
	public FNiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding;
	public TArray<FNiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings;
}
