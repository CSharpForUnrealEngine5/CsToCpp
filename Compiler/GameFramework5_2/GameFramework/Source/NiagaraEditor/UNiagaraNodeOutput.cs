namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOutput.h")]
public partial class UNiagaraNodeOutput : UNiagaraNode {
	public static UClass StaticClass() {return default;}
	///<summary>Outputs</summary>
	public TArray<FNiagaraVariable> Outputs;
	///<summary>ScriptType</summary>
	public ENiagaraScriptUsage ScriptType;
	///<summary>ScriptTypeId</summary>
	public FGuid ScriptTypeId;
	///<summary>ScriptTypeIndex_DEPRECATED</summary>
	public int ScriptTypeIndex_DEPRECATED;
}
