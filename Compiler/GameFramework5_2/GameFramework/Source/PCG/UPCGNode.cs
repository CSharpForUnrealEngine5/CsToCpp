#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGNode.h")]
public partial class UPCGNode : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the owning graph</summary>
	public  UPCGGraph GetGraph() { return default; }
	///<summary>Adds an edge in the owning graph to the given &quot;To&quot; node.</summary>
	public  UPCGNode AddEdgeTo(string FromPinLabel,UPCGNode To,string ToPinLabel) { return default; }
	///<summary>Removes an edge originating from this node</summary>
	public  bool RemoveEdgeTo(string FromPinLable,UPCGNode To,string ToPinLabel) { return default; }
	///<summary>Returns the settings this node holds (either directly or through an instance)</summary>
	public  UPCGSettings GetSettings() { return default; }
	///<summary>GetNodePosition</summary>
	public  void GetNodePosition(int OutPositionX,int OutPositionY) {}
	///<summary>SetNodePosition</summary>
	public  void SetNodePosition(int InPositionX,int InPositionY) {}
	///<summary>DefaultSettings_DEPRECATED</summary>
	public UPCGSettings DefaultSettings_DEPRECATED;
	///<summary>NodeTitle</summary>
	public string NodeTitle;
	///<summary>NodeTitleColor</summary>
	public FLinearColor NodeTitleColor;
	///<summary>PositionX</summary>
	public int PositionX;
	///<summary>PositionY</summary>
	public int PositionY;
	///<summary>NodeComment</summary>
	public string NodeComment;
	///<summary>bCommentBubblePinned</summary>
	public bool bCommentBubblePinned;
	///<summary>bCommentBubbleVisible</summary>
	public bool bCommentBubbleVisible;
	///<summary>Note: do not set this property directly from code, use SetSettingsInterface instead</summary>
	public UPCGSettingsInterface SettingsInterface;
	///<summary>OutboundNodes_DEPRECATED</summary>
	public TArray<UPCGNode> OutboundNodes_DEPRECATED;
	///<summary>InboundEdges_DEPRECATED</summary>
	public TArray<UPCGEdge> InboundEdges_DEPRECATED;
	///<summary>OutboundEdges_DEPRECATED</summary>
	public TArray<UPCGEdge> OutboundEdges_DEPRECATED;
	///<summary>InputPins</summary>
	public TArray<UPCGPin> InputPins;
	///<summary>OutputPins</summary>
	public TArray<UPCGPin> OutputPins;
}
