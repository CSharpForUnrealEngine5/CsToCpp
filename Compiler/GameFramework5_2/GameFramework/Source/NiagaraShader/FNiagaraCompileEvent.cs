#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraShared.h")]
///<summary>Records necessary information to give UI cues for errors/logs/warnings during compile.</summary>
public partial struct FNiagaraCompileEvent {
// NiagaraCompileEvent
	public FNiagaraCompileEventSeverity Severity;
	public string Message;
	public string ShortDescription;
	public bool bDismissable;
	public FGuid NodeGuid;
	public FGuid PinGuid;
	public TArray<FGuid> StackGuids;
	public FNiagaraCompileEventSource Source;
}
