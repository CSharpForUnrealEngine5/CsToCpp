namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessages.h")]
public partial class UNiagaraMessageDataText : UNiagaraMessageData {
	public static UClass StaticClass() {return default;}
	///<summary>MessageText</summary>
	public FText MessageText;
	///<summary>ShortDescription</summary>
	public FText ShortDescription;
	///<summary>MessageSeverity</summary>
	public ENiagaraMessageSeverity MessageSeverity;
	///<summary>bAllowDismissal</summary>
	public bool bAllowDismissal;
	///<summary>TopicName</summary>
	public FName TopicName;
}
