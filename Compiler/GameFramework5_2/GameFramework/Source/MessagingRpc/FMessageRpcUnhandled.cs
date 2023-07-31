#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message for notifying RPC clients that a call was not handled by the server.</summary>
[CppInclude("MessageRpcMessages.h")]
public partial struct FMessageRpcUnhandled {
	public FGuid CallId;
}
