#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
