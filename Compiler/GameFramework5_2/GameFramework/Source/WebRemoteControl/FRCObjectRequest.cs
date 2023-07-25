#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to access an object</summary>
public partial struct FRCObjectRequest {
// RCObjectRequest
	public string ObjectPath;
	public string PropertyName;
	public bool ResetToDefault;
	public bool GenerateTransaction;
	public ERCModifyOperation Operation;
	public ERCAccess Access;
}
