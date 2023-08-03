#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGEdge.h")]
public partial class UPCGEdge : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>~End UObject interface</summary>
	public string InboundLabel_DEPRECATED;
	///<summary>InboundNode_DEPRECATED</summary>
	public UPCGNode InboundNode_DEPRECATED;
	///<summary>OutboundLabel_DEPRECATED</summary>
	public string OutboundLabel_DEPRECATED;
	///<summary>OutboundNode_DEPRECATED</summary>
	public UPCGNode OutboundNode_DEPRECATED;
	///<summary>InputPin</summary>
	public UPCGPin InputPin;
	///<summary>OutputPin</summary>
	public UPCGPin OutputPin;
}
