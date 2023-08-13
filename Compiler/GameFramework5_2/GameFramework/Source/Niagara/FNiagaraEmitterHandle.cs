namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores emitter information within the context of a System.</summary>
[CppInclude("NiagaraEmitterHandle.h")]
public partial struct FNiagaraEmitterHandle {
	public FGuid Id;
	public string IdName;
	public bool bIsEnabled;
	public string Name;
	public UNiagaraEmitter Source_DEPRECATED;
	public UNiagaraEmitter LastMergedSource_DEPRECATED;
	public bool bIsolated;
	public UNiagaraEmitter Instance_DEPRECATED;
	public FVersionedNiagaraEmitter VersionedInstance;
}
