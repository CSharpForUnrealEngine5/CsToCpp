namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message for updating the progress of an RPC call.</summary>
[CppInclude("MessageRpcMessages.h")]
public partial struct FMessageRpcProgress {
	public float Completion;
	public FGuid CallId;
	public string StatusText;
}
