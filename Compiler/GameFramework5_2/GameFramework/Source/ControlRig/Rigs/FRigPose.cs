#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyPose.h")]
public partial struct FRigPose {
	public TArray<FRigPoseElement> Elements;
	public int HierarchyTopologyVersion;
	public int PoseHash;
}
