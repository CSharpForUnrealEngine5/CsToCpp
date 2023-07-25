#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataSetCompiledData.h")]
public partial struct FNiagaraDataSetCompiledData {
// NiagaraDataSetCompiledData
	public TArray<FNiagaraVariable> Variables;
	public TArray<FNiagaraVariableLayoutInfo> VariableLayouts;
	public FNiagaraDataSetID ID;
	public uint TotalFloatComponents;
	public uint TotalInt32Components;
	public uint TotalHalfComponents;
	public bool bRequiresPersistentIDs;
	public ENiagaraSimTarget SimTarget;
}
