#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message for canceling an RPC call.</summary>
[CppInclude("MessageRpcMessages.h")]
public partial struct FMessageRpcCancel {
	public FGuid CallId;
}
