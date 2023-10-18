namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptResolvedDataInterfaceInfo {
	public FName Name;
	public FName CompileName;
	public string ResolvedSourceEmitterName;
	public FNiagaraVariableBase ResolvedVariable;
	public FNiagaraVariableBase ParameterStoreVariable;
	public bool bIsInternal;
	public UNiagaraDataInterface ResolvedDataInterface;
	public int UserPtrIdx;
}
