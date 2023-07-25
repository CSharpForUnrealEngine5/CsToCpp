#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigSkeleton.h")]
public partial struct FIKRigSkeleton {
// IKRigSkeleton
	public TArray<string> BoneNames;
	public TArray<int> ParentIndices;
	public TArray<string> ExcludedBones;
	public TArray<FTransform> CurrentPoseGlobal;
	public TArray<FTransform> CurrentPoseLocal;
	public TArray<FTransform> RefPoseGlobal;
}
