namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to call a function</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCCallRequest {
	public string ObjectPath;
	public string FunctionName;
	public bool GenerateTransaction;
}
