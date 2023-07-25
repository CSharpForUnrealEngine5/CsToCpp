#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MessageRpcMessages.h")]
///<summary>Message for notifying RPC clients that a call was not handled by the server.</summary>
public partial struct FMessageRpcUnhandled {
// MessageRpcUnhandled
	public FGuid CallId;
}
