#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A niagara graph node which represents an emitter and it&#39;s parameters.</summary>
[CppInclude("NiagaraNodeEmitter.h")]
public partial class UNiagaraNodeEmitter : UNiagaraNodeWithDynamicPins {
	///<summary>The System that owns the emitter which is represented by this node.</summary>
	public UNiagaraSystem OwnerSystem;
	///<summary>The id of the emitter handle which points to the emitter represented by this node.</summary>
	public FGuid EmitterHandleId;
	///<summary>The display name for the title bar of this node.</summary>
	public string DisplayName;
	///<summary>ScriptType</summary>
	public ENiagaraScriptUsage ScriptType;
}
