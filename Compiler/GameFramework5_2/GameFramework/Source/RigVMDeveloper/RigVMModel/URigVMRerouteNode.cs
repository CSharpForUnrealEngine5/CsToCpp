#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reroute node is used to visually improve the</summary>
[CppInclude("RigVMModel/Nodes/RigVMRerouteNode.h")]
public partial class URigVMRerouteNode : URigVMTemplateNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if this node should be shown as a full node,</summary>
	public  bool GetShowsAsFullNode() { return default; }
	///<summary>bShowAsFullNode</summary>
	public bool bShowAsFullNode;
}
