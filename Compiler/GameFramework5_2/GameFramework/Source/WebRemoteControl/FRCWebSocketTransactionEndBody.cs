#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to end a transaction.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketTransactionEndBody {
	public int TransactionId;
}
