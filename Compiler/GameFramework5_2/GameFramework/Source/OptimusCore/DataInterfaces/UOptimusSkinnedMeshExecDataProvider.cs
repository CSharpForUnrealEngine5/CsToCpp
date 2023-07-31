#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshExec.h")]
public partial class UOptimusSkinnedMeshExecDataProvider : UComputeDataProvider {
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
	///<summary>Domain</summary>
	public EOptimusSkinnedMeshExecDomain Domain;
}
