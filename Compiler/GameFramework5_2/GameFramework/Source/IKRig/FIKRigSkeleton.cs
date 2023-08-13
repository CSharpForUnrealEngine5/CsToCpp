namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigSkeleton.h")]
public partial struct FIKRigSkeleton {
	public TArray<string> BoneNames;
	public TArray<int> ParentIndices;
	public TArray<string> ExcludedBones;
	public TArray<FTransform> CurrentPoseGlobal;
	public TArray<FTransform> CurrentPoseLocal;
	public TArray<FTransform> RefPoseGlobal;
}
