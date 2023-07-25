#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusDeformerInstance.h")]
///<summary>Structure with cached state for a single compute graph.</summary>
public partial struct FOptimusDeformerInstanceExecInfo {
// OptimusDeformerInstanceExecInfo
	public string GraphName;
	public EOptimusNodeGraphType GraphType;
	public UComputeGraph ComputeGraph;
	public FComputeGraphInstance ComputeGraphInstance;
}
