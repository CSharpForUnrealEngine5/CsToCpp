#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraOutlinerEmitterInstanceData {
// NiagaraOutlinerEmitterInstanceData
	public string EmitterName;
	public ENiagaraSimTarget SimTarget;
	public ENiagaraExecutionState ExecState;
	public int NumParticles;
	public bool bRequiresPersistentIDs;
}
