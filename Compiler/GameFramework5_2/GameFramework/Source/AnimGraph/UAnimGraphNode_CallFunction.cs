namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_CallFunction.h")]
public partial class UAnimGraphNode_CallFunction : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Inner graph we maintain to hook into the function call machinery</summary>
	public UEdGraph InnerGraph;
	///<summary>Inner node we maintain to hook into the function call machinery</summary>
	public UK2Node_CallFunction CallFunctionPrototype;
	///<summary>Node</summary>
	public FAnimNode_CallFunction Node;
}
