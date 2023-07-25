#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a comment node's text in the graph.</summary>
public partial struct FRigVMSetCommentTextAction {
// RigVMSetCommentTextAction
	public string NodePath;
	public string OldText;
	public string NewText;
	public int OldFontSize;
	public int NewFontSize;
	public bool bOldBubbleVisible;
	public bool bNewBubbleVisible;
	public bool bOldColorBubble;
	public bool bNewColorBubble;
}
