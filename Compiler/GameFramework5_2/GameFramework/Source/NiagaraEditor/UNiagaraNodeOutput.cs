#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOutput.h")]
public partial class UNiagaraNodeOutput : UNiagaraNode {
// NiagaraNodeOutput
	public TArray<FNiagaraVariable> Outputs;
	public ENiagaraScriptUsage ScriptType;
	public FGuid ScriptTypeId;
	public int ScriptTypeIndex_DEPRECATED;
}
