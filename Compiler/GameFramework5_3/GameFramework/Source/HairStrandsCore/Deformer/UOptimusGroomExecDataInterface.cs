namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for executing kernels over a skinned mesh domain.</summary>
[CppInclude("Deformer/DeformerDataInterfaceGroomExec.h")]
public partial class UOptimusGroomExecDataInterface : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Domain</summary>
	public EOptimusGroomExecDomain Domain;
}
