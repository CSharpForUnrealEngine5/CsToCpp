namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Records necessary information to give UI cues for errors/logs/warnings during compile.</summary>
[CppInclude("NiagaraShared.h")]
public partial struct FNiagaraCompileEvent {
	public FNiagaraCompileEventSeverity Severity;
	public string Message;
	public string ShortDescription;
	public bool bDismissable;
	public FGuid NodeGuid;
	public FGuid PinGuid;
	public TArray<FGuid> StackGuids;
	public FNiagaraCompileEventSource Source;
}
