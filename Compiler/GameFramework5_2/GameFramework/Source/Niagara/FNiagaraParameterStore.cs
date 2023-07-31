#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base storage class for Niagara parameter values.</summary>
[CppInclude("NiagaraParameterStore.h")]
public partial struct FNiagaraParameterStore {
	public TWeakObjectPtr<UObject> Owner;
	public TMap<FNiagaraVariable,int> ParameterOffsets;
	public TArray<FNiagaraVariableWithOffset> SortedParameterOffsets;
	public TArray<byte> ParameterData;
	public TArray<UNiagaraDataInterface> DataInterfaces;
	public TArray<UObject> UObjects;
	public TArray<FNiagaraPositionSource> OriginalPositionData;
	public string DebugName;
	public TMap<FNiagaraVariable,FGuid> ParameterGuidMapping;
}
