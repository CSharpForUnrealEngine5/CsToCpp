namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Interface for reading skeletal mesh and tetrahedral mesh bindings.</summary>
[CppInclude("DataInterfaces/DIFleshDeformer.h")]
public partial class UDIFleshDeformer : UOptimusComputeDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>FleshDeformerParameters</summary>
	public FFleshDeformerParameters FleshDeformerParameters;
}
