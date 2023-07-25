#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphNode.h")]
public partial class UEdGraphNode : UObject {
// EdGraphNode
	public TArray<UEdGraphPin_Deprecated> DeprecatedPins;
	public int NodePosX;
	public int NodePosY;
	public int NodeWidth;
	public int NodeHeight;
	public byte AdvancedPinDisplay;
	public ENodeEnabledState EnabledState;
	public bool bDisplayAsDisabled;
	public bool bUserSetEnabledState;
	public bool bIsNodeEnabled_DEPRECATED;
	public bool bCanResizeNode;
	public bool bIsIntermediateNode;
	public bool bHasCompilerMessage;
	public bool bCommentBubblePinned;
	public bool bCommentBubbleVisible;
	public bool bCommentBubbleMakeVisible;
	public bool bCanRenameNode;
	public string NodeUpgradeMessage;
	public string NodeComment;
	public int ErrorType;
	public string ErrorMsg;
	public FGuid NodeGuid;
}
