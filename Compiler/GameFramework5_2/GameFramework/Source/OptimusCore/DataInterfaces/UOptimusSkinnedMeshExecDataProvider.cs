namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshExec.h")]
public partial class UOptimusSkinnedMeshExecDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
	///<summary>Domain</summary>
	public EOptimusSkinnedMeshExecDomain Domain;
}
