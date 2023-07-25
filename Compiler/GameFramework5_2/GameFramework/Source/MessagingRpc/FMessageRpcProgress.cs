#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MessageRpcMessages.h")]
///<summary>Message for updating the progress of an RPC call.</summary>
public partial struct FMessageRpcProgress {
// MessageRpcProgress
	public float Completion;
	public FGuid CallId;
	public string StatusText;
}
