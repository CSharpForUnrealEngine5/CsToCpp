#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshExec.h")]
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
public partial class UOptimusSkinnedMeshExecDataProvider : UComputeDataProvider {
// OptimusSkinnedMeshExecDataProvider
	public USkinnedMeshComponent SkinnedMesh;
	public EOptimusSkinnedMeshExecDomain Domain;
}
