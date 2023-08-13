namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message for canceling an RPC call.</summary>
[CppInclude("MessageRpcMessages.h")]
public partial struct FMessageRpcCancel {
	public FGuid CallId;
}
