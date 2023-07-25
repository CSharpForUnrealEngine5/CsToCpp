#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceGraph.h")]
///<summary>Compute Framework Data Interface used for marshaling compute graph parameters and variables.</summary>
public partial class UOptimusGraphDataInterface : UComputeDataInterface {
// OptimusGraphDataInterface
	public TArray<FOptimusGraphVariableDescription> Variables;
	public int ParameterBufferSize;
}
