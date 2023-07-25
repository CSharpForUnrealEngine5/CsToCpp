#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMCommentNode.h")]
///<summary>Comment Nodes can be used to annotate a Graph by adding</summary>
public partial class URigVMCommentNode : URigVMNode {
// RigVMCommentNode
	public string GetCommentText() { return default; }
	public int GetCommentFontSize() { return default; }
	public bool GetCommentBubbleVisible() { return default; }
	public bool GetCommentColorBubble() { return default; }
	public string CommentText;
	public int FontSize;
	public bool bBubbleVisible;
	public bool bColorBubble;
}
