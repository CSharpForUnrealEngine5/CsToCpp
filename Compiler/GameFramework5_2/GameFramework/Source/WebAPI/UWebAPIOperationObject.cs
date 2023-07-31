#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Baseclass for an asynchronous Http request/response operation.</summary>
[CppInclude("WebAPIOperationObject.h")]
public partial class UWebAPIOperationObject : UObject {
	///<summary>Can contain a response or status message.</summary>
	public string Message;
}
