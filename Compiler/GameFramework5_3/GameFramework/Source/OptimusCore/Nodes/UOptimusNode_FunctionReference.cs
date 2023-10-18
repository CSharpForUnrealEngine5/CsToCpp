namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/OptimusNode_FunctionReference.h")]
public partial class UOptimusNode_FunctionReference : UOptimusNode {
	public static UClass StaticClass() {return default;}
	///<summary>The graph that owns us. This contains all the necessary pin information to add on</summary>
	public UOptimusFunctionNodeGraph FunctionGraph;
}
