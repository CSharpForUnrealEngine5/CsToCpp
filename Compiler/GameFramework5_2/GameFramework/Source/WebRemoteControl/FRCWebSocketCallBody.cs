#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to call an exposed function on an object.</summary>
public partial struct FRCWebSocketCallBody {
// RCWebSocketCallBody
	public ERCTransactionMode TransactionMode;
	public int TransactionId;
	public long SequenceNumber;
}
