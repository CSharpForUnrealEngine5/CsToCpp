#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessages.h")]
public partial class UNiagaraMessageDataText : UNiagaraMessageData {
	///<summary>MessageText</summary>
	public string MessageText;
	///<summary>ShortDescription</summary>
	public string ShortDescription;
	///<summary>MessageSeverity</summary>
	public ENiagaraMessageSeverity MessageSeverity;
	///<summary>bAllowDismissal</summary>
	public bool bAllowDismissal;
	///<summary>TopicName</summary>
	public string TopicName;
}
