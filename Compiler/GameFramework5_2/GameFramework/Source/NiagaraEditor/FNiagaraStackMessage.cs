#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessages.h")]
public partial struct FNiagaraStackMessage {
// NiagaraStackMessage
	public string MessageText;
	public string ShortDescription;
	public ENiagaraMessageSeverity MessageSeverity;
	public bool bAllowDismissal;
	public FGuid Guid;
}
