namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for executing kernels over a skinned mesh domain.</summary>
[CppInclude("Deformer/DeformerDataInterfaceGroomExec.h")]
public partial class UOptimusGroomExecDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>GroomComponent</summary>
	public UGroomComponent GroomComponent;
	///<summary>Domain</summary>
	public EOptimusGroomExecDomain Domain;
}
