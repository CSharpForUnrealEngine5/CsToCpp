#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_CallFunction.h")]
public partial class UK2Node_CallFunction : UK2Node {
	///<summary>Indicates that this is a call to a pure function</summary>
	public bool bIsPureFunc;
	///<summary>Indicates that this is a call to a const function</summary>
	public bool bIsConstFunc;
	///<summary>Indicates that during compile we want to create multiple exec pins from an enum param</summary>
	public bool bWantsEnumToExecExpansion;
	///<summary>Indicates that this is a call to an interface function</summary>
	public bool bIsInterfaceCall;
	///<summary>Indicates that this is a call to a final / superclass&#39;s function</summary>
	public bool bIsFinalFunction;
	///<summary>Indicates that this is a &#39;bead&#39; function with no fixed location; it is drawn between the nodes that it is wired to</summary>
	public bool bIsBeadFunction;
	///<summary>The function to call</summary>
	public FMemberReference FunctionReference;
	///<summary>The name of the function to call</summary>
	public string CallFunctionName_DEPRECATED;
	///<summary>The class that the function is from.</summary>
	public UClass CallFunctionClass_DEPRECATED;
}
