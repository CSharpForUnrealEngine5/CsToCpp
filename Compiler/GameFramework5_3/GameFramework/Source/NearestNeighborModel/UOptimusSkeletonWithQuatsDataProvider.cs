namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
[CppInclude("OptimusDataInterfaceSkeletonWithQuats.h")]
public partial class UOptimusSkeletonWithQuatsDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
}
