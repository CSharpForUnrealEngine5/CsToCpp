#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AIGraphNode.h")]
public partial class UAIGraphNode : UEdGraphNode {
// AIGraphNode
	public FGraphNodeClassData ClassData;
	public UObject NodeInstance;
	public UAIGraphNode ParentNode;
	public TArray<UAIGraphNode> SubNodes;
	public int CopySubNodeIndex;
	public bool bIsReadOnly;
	public bool bIsSubNode;
	public string ErrorMessage;
}
