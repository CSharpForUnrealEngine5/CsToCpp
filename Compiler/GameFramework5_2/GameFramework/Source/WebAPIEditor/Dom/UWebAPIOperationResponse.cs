#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperationResponse : UWebAPIModel {
	public static UClass StaticClass() {return default;}
	///<summary>Where this parameter is stored/encoded in the response.</summary>
	public EWebAPIResponseStorage Storage;
	///<summary>Http response code.</summary>
	public uint Code;
	///<summary>Optional message based on the response status or result.</summary>
	public string Message;
}
