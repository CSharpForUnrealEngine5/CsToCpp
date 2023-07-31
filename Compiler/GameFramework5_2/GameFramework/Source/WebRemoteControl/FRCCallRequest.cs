#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to call a function</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCCallRequest {
	public string ObjectPath;
	public string FunctionName;
	public bool GenerateTransaction;
}
