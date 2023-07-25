#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request made via websocket to start a transaction.</summary>
public partial struct FRCWebSocketTransactionStartBody {
// RCWebSocketTransactionStartBody
	public string Description;
	public int TransactionId;
}
