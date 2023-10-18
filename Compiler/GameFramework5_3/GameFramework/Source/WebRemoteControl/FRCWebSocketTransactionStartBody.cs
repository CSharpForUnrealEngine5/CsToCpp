namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to start a transaction.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCWebSocketTransactionStartBody {
	public string Description;
	public int TransactionId;
}
