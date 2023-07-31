#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to call an exposed function on an object.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketCallBody {
	public ERCTransactionMode TransactionMode;
	public int TransactionId;
	public long SequenceNumber;
}
