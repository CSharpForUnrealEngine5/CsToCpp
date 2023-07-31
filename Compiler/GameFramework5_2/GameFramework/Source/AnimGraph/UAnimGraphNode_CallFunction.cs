#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_CallFunction.h")]
public partial class UAnimGraphNode_CallFunction : UAnimGraphNode_Base {
	///<summary>Inner graph we maintain to hook into the function call machinery</summary>
	public UEdGraph InnerGraph;
	///<summary>Inner node we maintain to hook into the function call machinery</summary>
	public UK2Node_CallFunction CallFunctionPrototype;
	///<summary>Node</summary>
	public FAnimNode_CallFunction Node;
}
