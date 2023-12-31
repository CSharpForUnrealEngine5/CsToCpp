namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for executing kernels over a skinned mesh domain.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshExec.h")]
public partial class UOptimusSkinnedMeshExecDataInterface : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Domain</summary>
	public EOptimusSkinnedMeshExecDomain Domain;
}
