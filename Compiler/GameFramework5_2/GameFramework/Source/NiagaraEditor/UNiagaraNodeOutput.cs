#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOutput.h")]
public partial class UNiagaraNodeOutput : UNiagaraNode {
	///<summary>Outputs</summary>
	public TArray<FNiagaraVariable> Outputs;
	///<summary>ScriptType</summary>
	public ENiagaraScriptUsage ScriptType;
	///<summary>ScriptTypeId</summary>
	public FGuid ScriptTypeId;
	///<summary>ScriptTypeIndex_DEPRECATED</summary>
	public int ScriptTypeIndex_DEPRECATED;
}
