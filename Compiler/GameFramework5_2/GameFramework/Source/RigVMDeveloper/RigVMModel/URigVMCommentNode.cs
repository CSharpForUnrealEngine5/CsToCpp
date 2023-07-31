#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Comment Nodes can be used to annotate a Graph by adding</summary>
[CppInclude("RigVMModel/Nodes/RigVMCommentNode.h")]
public partial class URigVMCommentNode : URigVMNode {
	///<summary>Returns the current user provided text of this comment.</summary>
	public  string GetCommentText() { return default; }
	///<summary>Returns the current user provided font size of this comment.</summary>
	public  int GetCommentFontSize() { return default; }
	///<summary>Returns the current user provided bubble visibility of this comment.</summary>
	public  bool GetCommentBubbleVisible() { return default; }
	///<summary>Returns the current user provided bubble color inheritance of this comment.</summary>
	public  bool GetCommentColorBubble() { return default; }
	///<summary>CommentText</summary>
	public string CommentText;
	///<summary>FontSize</summary>
	public int FontSize;
	///<summary>bBubbleVisible</summary>
	public bool bBubbleVisible;
	///<summary>bColorBubble</summary>
	public bool bColorBubble;
}
