namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for writing skinned mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshWrite.h")]
public partial class UOptimusSkinnedMeshWriteDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
}
