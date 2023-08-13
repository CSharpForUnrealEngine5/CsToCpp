namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraOutlinerEmitterInstanceData {
	public string EmitterName;
	public ENiagaraSimTarget SimTarget;
	public ENiagaraExecutionState ExecState;
	public int NumParticles;
	public bool bRequiresPersistentIDs;
}
