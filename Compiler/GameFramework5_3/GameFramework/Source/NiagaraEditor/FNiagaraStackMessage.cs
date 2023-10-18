namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessages.h")]
public partial struct FNiagaraStackMessage {
	public FText MessageText;
	public FText ShortDescription;
	public ENiagaraMessageSeverity MessageSeverity;
	public bool bAllowDismissal;
	public FGuid Guid;
}
