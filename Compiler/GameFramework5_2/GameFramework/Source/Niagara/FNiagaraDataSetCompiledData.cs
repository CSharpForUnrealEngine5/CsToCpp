namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataSetCompiledData.h")]
public partial struct FNiagaraDataSetCompiledData {
	public TArray<FNiagaraVariable> Variables;
	public TArray<FNiagaraVariableLayoutInfo> VariableLayouts;
	public FNiagaraDataSetID ID;
	public uint TotalFloatComponents;
	public uint TotalInt32Components;
	public uint TotalHalfComponents;
	public bool bRequiresPersistentIDs;
	public ENiagaraSimTarget SimTarget;
}
