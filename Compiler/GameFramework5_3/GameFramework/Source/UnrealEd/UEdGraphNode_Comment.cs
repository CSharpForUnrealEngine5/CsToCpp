namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraphNode_Comment.h")]
public partial class UEdGraphNode_Comment : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>Color to style comment with</summary>
	public FLinearColor CommentColor;
	///<summary>Size of the text in the comment box</summary>
	public int FontSize;
	///<summary>Whether to show a zoom-invariant comment bubble when zoomed out (making the comment readable at any distance).</summary>
	public bool bCommentBubbleVisible_InDetailsPanel;
	///<summary>Whether to use Comment Color to color the background of the comment bubble shown when zoomed out.</summary>
	public bool bColorCommentBubble;
	///<summary>Whether the comment should move any fully enclosed nodes around when it is moved</summary>
	public ECommentBoxMode MoveMode;
	///<summary>comment Depth</summary>
	public int CommentDepth;
}
