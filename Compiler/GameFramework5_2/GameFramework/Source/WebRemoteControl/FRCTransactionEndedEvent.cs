#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client that contributed to a transaction, indicating that the transaction was either cancelled or finalized.</summary>
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCTransactionEndedEvent {
	public string Type;
	public int TransactionId;
	public long SequenceNumber;
}
