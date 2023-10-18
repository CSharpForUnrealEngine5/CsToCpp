namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: Event action that spawns other whole Systems?</summary>
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraEventReceiverProperties {
	public FName Name;
	public FName SourceEventGenerator;
	public FName SourceEmitter;
}
