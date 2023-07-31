#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>View settings used in the Niagara Outliner.</summary>
[CppInclude("NiagaraOutliner.h")]
public partial struct FNiagaraOutlinerFilterSettings {
	public bool bFilterBySystemExecutionState;
	public bool bFilterByEmitterExecutionState;
	public bool bFilterByEmitterSimTarget;
	public bool bFilterBySystemCullState;
	public ENiagaraExecutionState SystemExecutionState;
	public ENiagaraExecutionState EmitterExecutionState;
	public ENiagaraSimTarget EmitterSimTarget;
	public bool bSystemCullState;
}
