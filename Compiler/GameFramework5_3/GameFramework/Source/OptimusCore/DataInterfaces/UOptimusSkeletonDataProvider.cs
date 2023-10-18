namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkeleton.h")]
public partial class UOptimusSkeletonDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
}
