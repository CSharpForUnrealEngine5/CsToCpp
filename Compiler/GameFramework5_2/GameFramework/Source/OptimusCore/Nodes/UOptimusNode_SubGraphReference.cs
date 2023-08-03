#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_SubGraphReference.h")]
public partial class UOptimusNode_SubGraphReference : UOptimusNode {
	public static UClass StaticClass() {return default;}
	///<summary>The graph that owns us. This contains all the necessary pin information to add on</summary>
	public UOptimusNodeSubGraph SubGraph;
}
