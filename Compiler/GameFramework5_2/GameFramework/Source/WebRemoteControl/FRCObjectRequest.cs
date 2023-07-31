#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to access an object</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCObjectRequest {
	public string ObjectPath;
	public string PropertyName;
	public bool ResetToDefault;
	public bool GenerateTransaction;
	public ERCModifyOperation Operation;
	public ERCAccess Access;
}
