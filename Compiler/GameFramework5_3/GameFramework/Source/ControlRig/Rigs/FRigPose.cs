namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyPose.h")]
public partial struct FRigPose {
	public TArray<FRigPoseElement> Elements;
	public int HierarchyTopologyVersion;
	public int PoseHash;
}
