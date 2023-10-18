namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceConnectivity.h")]
public partial class UOptimusConnectivityDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
}
