#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to call a function</summary>
public partial struct FRCCallRequest {
// RCCallRequest
	public string ObjectPath;
	public string FunctionName;
	public bool GenerateTransaction;
}
