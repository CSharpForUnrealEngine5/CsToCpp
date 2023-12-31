namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a comment node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddCommentNodeAction {
	public string CommentText;
	public FVector2D Position;
	public FVector2D Size;
	public FLinearColor Color;
	public string NodePath;
}
