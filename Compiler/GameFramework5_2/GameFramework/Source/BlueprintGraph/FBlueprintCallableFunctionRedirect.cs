#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraphSchema_K2.h")]
///<summary>Structure used to automatically convert blueprintcallable functions (that have blueprint parameter) calls (in bp graph)</summary>
public partial struct FBlueprintCallableFunctionRedirect {
// BlueprintCallableFunctionRedirect
	public string ClassName;
	public string OldFunctionName;
	public string NewFunctionName;
	public string BlueprintParamName;
	public string ClassParamName;
}
