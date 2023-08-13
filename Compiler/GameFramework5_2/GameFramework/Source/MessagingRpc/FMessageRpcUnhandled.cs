namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message for notifying RPC clients that a call was not handled by the server.</summary>
[CppInclude("MessageRpcMessages.h")]
public partial struct FMessageRpcUnhandled {
	public FGuid CallId;
}
