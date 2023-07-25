#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceGraph.h")]
///<summary>Compute Framework Data Provider for marshaling compute graph parameters and variables.</summary>
public partial class UOptimusGraphDataProvider : UComputeDataProvider {
// OptimusGraphDataProvider
	public UMeshComponent MeshComponent;
	public UOptimusDeformerInstance DeformerInstance;
	public TArray<FOptimusGraphVariableDescription> Variables;
}
