namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure used to automatically convert blueprintcallable functions (that have blueprint parameter) calls (in bp graph)</summary>
[CppInclude("EdGraphSchema_K2.h")]
public partial struct FBlueprintCallableFunctionRedirect {
	public string ClassName;
	public string OldFunctionName;
	public string NewFunctionName;
	public string BlueprintParamName;
	public string ClassParamName;
}
