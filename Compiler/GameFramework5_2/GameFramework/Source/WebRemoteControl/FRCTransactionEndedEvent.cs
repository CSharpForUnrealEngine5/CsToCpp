#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
///<summary>Event sent to a client that contributed to a transaction, indicating that the transaction was either cancelled or finalized.</summary>
public partial struct FRCTransactionEndedEvent {
// RCTransactionEndedEvent
	public string Type;
	public int TransactionId;
	public long SequenceNumber;
}
