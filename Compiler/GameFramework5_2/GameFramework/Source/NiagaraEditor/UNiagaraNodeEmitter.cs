#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeEmitter.h")]
///<summary>A niagara graph node which represents an emitter and it's parameters.</summary>
public partial class UNiagaraNodeEmitter : UNiagaraNodeWithDynamicPins {
// NiagaraNodeEmitter
	public UNiagaraSystem OwnerSystem;
	public FGuid EmitterHandleId;
	public string DisplayName;
	public ENiagaraScriptUsage ScriptType;
}
