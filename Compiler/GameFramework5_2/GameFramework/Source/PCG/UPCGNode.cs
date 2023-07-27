#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGNode.h")]
public partial class UPCGNode : UObject {
// PCGNode
	public  UPCGGraph GetGraph() { return default; }
	public  UPCGNode AddEdgeTo(string FromPinLabel,UPCGNode To,string ToPinLabel) { return default; }
	public  bool RemoveEdgeTo(string FromPinLable,UPCGNode To,string ToPinLabel) { return default; }
	public  UPCGSettings GetSettings() { return default; }
	public  void GetNodePosition(int OutPositionX,int OutPositionY) {}
	public  void SetNodePosition(int InPositionX,int InPositionY) {}
	public UPCGSettings DefaultSettings_DEPRECATED;
	public string NodeTitle;
	public FLinearColor NodeTitleColor;
	public int PositionX;
	public int PositionY;
	public string NodeComment;
	public bool bCommentBubblePinned;
	public bool bCommentBubbleVisible;
	public UPCGSettingsInterface SettingsInterface;
	public TArray<UPCGNode> OutboundNodes_DEPRECATED;
	public TArray<UPCGEdge> InboundEdges_DEPRECATED;
	public TArray<UPCGEdge> OutboundEdges_DEPRECATED;
	public TArray<UPCGPin> InputPins;
	public TArray<UPCGPin> OutputPins;
}
