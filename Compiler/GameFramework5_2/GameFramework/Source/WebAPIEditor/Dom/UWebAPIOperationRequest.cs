namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperationRequest : UWebAPIModel {
	public static UClass StaticClass() {return default;}
	///<summary>Array of parameters contained in this request.</summary>
	public TArray<UWebAPIOperationParameter> Parameters;
}
