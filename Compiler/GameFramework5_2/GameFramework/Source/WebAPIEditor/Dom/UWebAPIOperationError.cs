#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperationError : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Http response code.</summary>
	public uint Code;
	///<summary>Describes this error, usually the error message.</summary>
	public string Description;
}
