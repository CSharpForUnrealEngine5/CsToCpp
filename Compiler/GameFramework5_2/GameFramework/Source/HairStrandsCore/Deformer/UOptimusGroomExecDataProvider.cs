#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Deformer/DeformerDataInterfaceGroomExec.h")]
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
public partial class UOptimusGroomExecDataProvider : UComputeDataProvider {
// OptimusGroomExecDataProvider
	public UGroomComponent GroomComponent;
	public EOptimusGroomExecDomain Domain;
}
