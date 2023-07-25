#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraOutliner.h")]
///<summary>View settings used in the Niagara Outliner.</summary>
public partial struct FNiagaraOutlinerFilterSettings {
// NiagaraOutlinerFilterSettings
	public bool bFilterBySystemExecutionState;
	public bool bFilterByEmitterExecutionState;
	public bool bFilterByEmitterSimTarget;
	public bool bFilterBySystemCullState;
	public ENiagaraExecutionState SystemExecutionState;
	public ENiagaraExecutionState EmitterExecutionState;
	public ENiagaraSimTarget EmitterSimTarget;
	public bool bSystemCullState;
}
