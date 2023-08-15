namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure with cached state for a single compute graph.</summary>
[CppInclude("OptimusDeformerInstance.h")]
public partial struct FOptimusDeformerInstanceExecInfo {
	public FName GraphName;
	public EOptimusNodeGraphType GraphType;
	public UComputeGraph ComputeGraph;
	public FComputeGraphInstance ComputeGraphInstance;
}
