namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base type for RPC messages.</summary>
[CppInclude("RpcMessage.h")]
public partial struct FRpcMessage {
	public FGuid CallId;
}
