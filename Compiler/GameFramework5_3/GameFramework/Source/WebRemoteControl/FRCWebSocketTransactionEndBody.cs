namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to end a transaction.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketTransactionEndBody {
	public int TransactionId;
}
