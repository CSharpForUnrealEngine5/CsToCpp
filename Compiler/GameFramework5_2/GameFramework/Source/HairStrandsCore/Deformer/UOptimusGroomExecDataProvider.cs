#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
[CppInclude("Deformer/DeformerDataInterfaceGroomExec.h")]
public partial class UOptimusGroomExecDataProvider : UComputeDataProvider {
	///<summary>GroomComponent</summary>
	public UGroomComponent GroomComponent;
	///<summary>Domain</summary>
	public EOptimusGroomExecDomain Domain;
}
