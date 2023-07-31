#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a comment node&#39;s text in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetCommentTextAction {
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
