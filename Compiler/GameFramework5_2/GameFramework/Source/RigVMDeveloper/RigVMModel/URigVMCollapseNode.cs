#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Collapse Node is a library node which stores the</summary>
[CppInclude("RigVMModel/Nodes/RigVMCollapseNode.h")]
public partial class URigVMCollapseNode : URigVMLibraryNode {
	public static UClass StaticClass() {return default;}
	///<summary>ContainedGraph</summary>
	public URigVMGraph ContainedGraph;
	///<summary>NodeCategory</summary>
	public string NodeCategory;
	///<summary>NodeKeywords</summary>
	public string NodeKeywords;
	///<summary>NodeDescription</summary>
	public string NodeDescription;
}
