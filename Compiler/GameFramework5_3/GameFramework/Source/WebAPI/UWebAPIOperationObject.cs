namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Baseclass for an asynchronous Http request/response operation.</summary>
[CppInclude("WebAPIOperationObject.h")]
public partial class UWebAPIOperationObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Can contain a response or status message.</summary>
	public FText Message;
}
