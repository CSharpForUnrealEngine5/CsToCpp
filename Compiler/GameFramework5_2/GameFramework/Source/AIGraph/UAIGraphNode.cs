#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AIGraphNode.h")]
public partial class UAIGraphNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>instance class</summary>
	public FGraphNodeClassData ClassData;
	///<summary>NodeInstance</summary>
	public UObject NodeInstance;
	///<summary>ParentNode</summary>
	public UAIGraphNode ParentNode;
	///<summary>SubNodes</summary>
	public TArray<UAIGraphNode> SubNodes;
	///<summary>subnode index assigned during copy operation to connect nodes again on paste</summary>
	public int CopySubNodeIndex;
	///<summary>if set, all modifications (including delete/cut) are disabled</summary>
	public bool bIsReadOnly;
	///<summary>if set, this node will be always considered as subnode</summary>
	public bool bIsSubNode;
	///<summary>error message for node</summary>
	public string ErrorMessage;
}
