namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure with cached state for a single compute graph.</summary>
[CppInclude("OptimusDeformerInstance.h")]
public partial struct FOptimusDeformerInstanceExecInfo {
	public string GraphName;
	public EOptimusNodeGraphType GraphType;
	public UComputeGraph ComputeGraph;
	public FComputeGraphInstance ComputeGraphInstance;
}
