#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphNode.h")]
public partial class UEdGraphNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of connector pins</summary>
	public TArray<UEdGraphPin_Deprecated> DeprecatedPins;
	///<summary>X position of node in the editor</summary>
	public int NodePosX;
	///<summary>Y position of node in the editor</summary>
	public int NodePosY;
	///<summary>Width of node in the editor; only used when the node can be resized</summary>
	public int NodeWidth;
	///<summary>Height of node in the editor; only used when the node can be resized</summary>
	public int NodeHeight;
	///<summary>Enum to indicate if a node has advanced-display-pins, and if they are shown</summary>
	public ENodeAdvancedPins AdvancedPinDisplay;
	///<summary>Indicates in what state the node is enabled, which may eliminate it from being compiled</summary>
	public ENodeEnabledState EnabledState;
	///<summary>bDisplayAsDisabled</summary>
	public bool bDisplayAsDisabled;
	///<summary>Indicates whether or not the user explicitly set the enabled state</summary>
	public bool bUserSetEnabledState;
	///<summary>(DEPRECATED) FALSE if the node is a disabled, which eliminates it from being compiled</summary>
	public bool bIsNodeEnabled_DEPRECATED;
	///<summary>If true, this node can be resized and should be drawn with a resize handle</summary>
	public bool bCanResizeNode;
	///<summary>Whether the node was created as part of an expansion step</summary>
	public bool bIsIntermediateNode;
	///<summary>Flag to check for compile error/warning</summary>
	public bool bHasCompilerMessage;
	///<summary>bCommentBubblePinned</summary>
	public bool bCommentBubblePinned;
	///<summary>Comment bubble visibility</summary>
	public bool bCommentBubbleVisible;
	///<summary>Make comment bubble visible</summary>
	public bool bCommentBubbleMakeVisible;
	///<summary>If true, this node can be renamed in the editor</summary>
	public bool bCanRenameNode;
	///<summary>Note for a node that lingers until saved</summary>
	public string NodeUpgradeMessage;
	///<summary>Comment string that is drawn on the node</summary>
	public string NodeComment;
	///<summary>Flag to store node specific compile error/warning</summary>
	public int ErrorType;
	///<summary>Error/Warning description</summary>
	public string ErrorMsg;
	///<summary>GUID to uniquely identify this node, to facilitate diffing versions of this graph</summary>
	public FGuid NodeGuid;
}
